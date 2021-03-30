using System.Collections.Generic;
using System.Linq;
using WCSharp.Events;
using WCSharp.Utils.Extensions;
using static War3Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// Auras constantly apply/refresh a linked <see cref="Buff"/> on valid targets in range.
	/// </summary>
	/// <typeparam name="T">The buff that will be applied by this aura.</typeparam>
	public abstract class Aura<T> : IAura
		where T : Buff
	{
		public bool Active { get; set; }
		public unit Caster { get; set; }
		public player CastingPlayer { get; set; }

		public float Radius { get; set; }
		/// <summary>
		/// The duration in seconds of buffs applied by this aura. Defaults to 2.1.
		/// <para>Unless you're making a pulsing aura, you will want the <see cref="Duration"/> to be greater than the <see cref="SearchInterval"/>.</para>
		/// </summary>
		public float Duration { get; set; } = 2.1f;
		public float SearchIntervalLeft { get; set; }
		/// <summary>
		/// How long in seconds between applications of this aura. Defaults to 1.0.
		/// </summary>
		public float SearchInterval { get; set; } = 1.0f;
		public StackBehaviour StackBehaviour { get; set; }
		/// <summary>
		/// A dictionary mapping units to active buffs.
		/// </summary>
		public Dictionary<unit, AuraBuff<T>> ActiveBuffsByUnit { get; set; }

		private string effectString;
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
						if (this.effect != null)
						{
							DestroyEffect(this.effect);
						}
						if (!string.IsNullOrEmpty(value))
						{
							this.effect = AddSpecialEffectTarget(value, Caster, this.effectAttachmentPoint);
						}
						else
						{
							this.effect = null;
						}
					}
				}
			}
		}

		private string effectAttachmentPoint = "origin";
		public string EffectAttachmentPoint
		{
			get => this.effectAttachmentPoint;
			set
			{
				value ??= "origin";
				if (this.effectAttachmentPoint != value)
				{
					this.effectAttachmentPoint = value;
					if (this.effect != null)
					{
						DestroyEffect(this.effect);
						this.effect = AddSpecialEffectTarget(this.effectString, Caster, this.effectAttachmentPoint);
					}
				}
			}
		}

		/// <summary>
		/// The actual in-game effect applied on the target.
		/// </summary>
		protected effect effect;
		private readonly group group = CreateGroup();

		public Aura(unit caster)
		{
			Caster = caster;
			CastingPlayer = GetOwningPlayer(caster);
			ActiveBuffsByUnit = new Dictionary<unit, AuraBuff<T>>();
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
		/// </summary>
		/// <param name="unit">The unit to evaluate</param>
		/// <returns>True if the given unit should receive the aura buff.</returns>
		protected abstract bool UnitFilter(unit unit);

		public void Apply()
		{
			if (!string.IsNullOrEmpty(this.effectString))
			{
				this.effect = AddSpecialEffectTarget(this.effectString, Caster, EffectAttachmentPoint);
			}
		}

		public void Action()
		{
			if (SearchIntervalLeft <= PeriodicEvents.SYSTEM_INTERVAL)
			{
				SearchIntervalLeft = SearchInterval;
				GroupEnumUnitsInRange(this.group, GetUnitX(Caster), GetUnitY(Caster), Radius, null);

				foreach (var unit in this.group.Enumerate())
				{
					if (ActiveBuffsByUnit.TryGetValue(unit, out var buff))
					{
						buff.Duration = Duration;
						buff.Buff.Duration = Duration;
					}
					else if (UnitFilter(unit))
					{
						var aura = (T)BuffSystem.Add(CreateAuraBuff(unit), StackBehaviour);
						aura.Duration = Duration;
						ActiveBuffsByUnit.Add(unit, new AuraBuff<T>
						{
							Buff = aura,
							Duration = Duration
						});
					}
				}
			}
			else
			{
				SearchIntervalLeft -= PeriodicEvents.SYSTEM_INTERVAL;
			}

			var removals = new List<unit>();

			foreach (var buff in ActiveBuffsByUnit)
			{
				if (buff.Value.Duration <= 0)
				{
					removals.Add(buff.Key);
					buff.Value.Buff.Stacks--;
				}
				else
				{
					buff.Value.Duration -= PeriodicEvents.SYSTEM_INTERVAL;
				}
			}

			foreach (var unitId in removals)
			{
				ActiveBuffsByUnit.Remove(unitId);
			}
		}

		public IEnumerable<Buff> GetActiveBuffs()
		{
			return ActiveBuffsByUnit.Values.Select(x => x.Buff);
		}

		public void Dispose()
		{
			if (this.effect != null)
			{
				DestroyEffect(this.effect);
			}
			DestroyGroup(this.group);
		}
	}
}
