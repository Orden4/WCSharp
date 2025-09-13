using System.Collections.Generic;
using System.Linq;
using WCSharp.Api;
using WCSharp.Shared.Extensions;
using static WCSharp.Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// Auras constantly apply/refresh a linked <see cref="Buff"/> on valid targets in range.
	/// </summary>
	/// <typeparam name="T">The buff that will be applied by this aura.</typeparam>
	public abstract class Aura<T> : IAura
		where T : Buff
	{
		private static readonly group group = CreateGroup();

		/// <inheritdoc/>
		public bool Active { get; set; }
		/// <inheritdoc/>
		public unit Caster { get; set; }
		/// <inheritdoc/>
		public player CastingPlayer { get; set; }

		/// <inheritdoc/>
		public float Radius { get; set; }
		/// <summary>
		/// The duration in seconds of buffs applied by this aura. Defaults to 3.1.
		/// <para>Unless you're making a pulsing aura, you will want the <see cref="Duration"/> to be greater than the <see cref="SearchInterval"/>.</para>
		/// </summary>
		public float Duration { get; set; } = 3.1f;
		/// <inheritdoc/>
		public float SearchIntervalLeft { get; set; }
		/// <summary>
		/// How long in seconds between applications of this aura. Defaults to 1.0.
		/// </summary>
		public float SearchInterval { get; set; } = 1.0f;
		/// <inheritdoc/>
		public StackBehaviour StackBehaviour { get; set; }

		private string effectString;
		/// <inheritdoc/>
		public string EffectString
		{
			get => this.effectString;
			set
			{
				if (this.effectString != value)
				{
					this.effectString = value;
					if (Active)
					{
						if (Effect != null)
						{
							DestroyEffect(Effect);
						}
						if (value != null)
						{
							Effect = AddSpecialEffectTarget(value, Caster, this.effectAttachmentPoint);
							if (this.effectScale != 1)
							{
								BlzSetSpecialEffectScale(Effect, this.effectScale);
							}
						}
						else
						{
							Effect = null;
						}
					}
				}
			}
		}

		private string effectAttachmentPoint = "origin";
		/// <inheritdoc/>
		public string EffectAttachmentPoint
		{
			get => this.effectAttachmentPoint;
			set
			{
				value ??= "origin";
				if (this.effectAttachmentPoint != value)
				{
					this.effectAttachmentPoint = value;
					if (Effect != null)
					{
						DestroyEffect(Effect);
						Effect = AddSpecialEffectTarget(this.effectString, Caster, this.effectAttachmentPoint);
					}
				}
			}
		}

		/// <summary>
		/// Internal effect scale. Used only when there is no effect present yet.
		/// </summary>
		private protected float effectScale = 1.0f;
		/// <inheritdoc/>
		public float EffectScale
		{
			get => Effect == null ? this.effectScale : BlzGetSpecialEffectScale(Effect);
			set
			{
				if (Effect != null)
				{
					BlzSetSpecialEffectScale(Effect, value);
				}
				this.effectScale = value;
			}
		}

		/// <inheritdoc/>
		public effect Effect { get; set; }

		private readonly List<AuraBuffDuration<T>> activeBuffs;

		/// <summary>
		/// Creates a new aura centered around the given caster.
		/// </summary>
		public Aura(unit caster)
		{
			Caster = caster;
			CastingPlayer = GetOwningPlayer(caster);
			this.activeBuffs = new();
		}

		/// <summary>
		/// Use this method to create new aura buffs.
		/// <para>Duration will be set automatically.</para>
		/// </summary>
		/// <param name="unit">The unit on who the aura buff will be applied.</param>
		/// <returns>The aura buff to be applied.</returns>
		protected abstract T CreateAuraBuff(unit unit);

		/// <summary>
		/// Use this method to filter units that should be affected by this aura.
		/// <para><b>Note:</b> If you override <see cref="GetAuraTargets"/>, this method will not be used.</para>
		/// </summary>
		/// <param name="unit">The unit to evaluate</param>
		/// <returns>True if the given unit should receive the aura buff.</returns>
		protected abstract bool UnitFilter(unit unit);

		/// <inheritdoc/>
		public void Apply()
		{
			if (this.effectString != null)
			{
				Effect = AddSpecialEffectTarget(this.effectString, Caster, this.effectAttachmentPoint);
				BlzSetSpecialEffectScale(Effect, this.effectScale);
			}
		}

		/// <inheritdoc/>
		public void Action()
		{
			if (!UnitAlive(Caster))
			{
				Active = false;
				return;
			}

			if (SearchIntervalLeft <= BuffSystem.TickInterval)
			{
				SearchIntervalLeft = SearchInterval;
				var units = GetAuraTargets();
				for (var i = 0; i < units.Count; i++)
				{
					var unit = units[i];
					var found = false;
					for (var j = 0; j < this.activeBuffs.Count; j++)
					{
						var activeBuff = this.activeBuffs[j];
						if (activeBuff.Unit == unit)
						{
							activeBuff.Duration = Duration;
							activeBuff.Buff.Duration = Duration;
							found = true;
						}
					}

					if (!found)
					{
						var aura = (T)BuffSystem.Add(CreateAuraBuff(unit), StackBehaviour);
						aura.Duration = Duration;
						this.activeBuffs.Add(new AuraBuffDuration<T>(unit, aura, Duration));
					}
				}
			}
			else
			{
				SearchIntervalLeft -= BuffSystem.TickInterval;
			}

			for (var i = this.activeBuffs.Count - 1; i >= 0; i--)
			{
				var buff = this.activeBuffs[i];
				if (buff.Duration <= 0)
				{
					buff.Buff.Stacks--;
					this.activeBuffs.RemoveAt(i);
				}
				else
				{
					buff.Duration -= BuffSystem.TickInterval;
				}
			}
		}

		/// <summary>
		/// Default implementation for retrieving the units that should be affected by the aura.
		/// <para>If you have a custom system (e.g. spatial hashing), you can override this to avoid using the default group-based search.</para>
		/// </summary>
		protected virtual List<unit> GetAuraTargets()
		{
			GroupEnumUnitsInRange(group, GetUnitX(Caster), GetUnitY(Caster), Radius, null);
			return group.ToList(UnitFilter);
		}

		/// <inheritdoc/>
		public IEnumerable<Buff> GetActiveBuffs()
		{
			return this.activeBuffs.Select(x => x.Buff);
		}

		/// <inheritdoc/>
		public void Dispose()
		{
			if (Effect != null)
			{
				DestroyEffect(Effect);
			}
		}
	}
}
