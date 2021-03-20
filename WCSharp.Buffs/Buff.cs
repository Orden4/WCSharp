using System.Collections.Generic;
using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Buffs
{
	public abstract class Buff : IPeriodicAction
	{
		/// <summary>
		/// Setting this to false will immediately end the buff.
		/// </summary>
		public bool Active { get; set; }
		/// <summary>
		/// The unit that applied the buff.
		/// </summary>
		public unit Caster { get; set; }
		/// <summary>
		/// The owner of the caster. Automatically set on application.
		/// <para>Does NOT update automatically! If this is desired, you can use <see cref="BuffSystem.RegisterForOwnershipChanges"/>.</para>
		/// </summary>
		public player CastingPlayer { get; set; }
		/// <summary>
		/// The target to which this buff is attached.
		/// </summary>
		public unit Target { get; set; }
		/// <summary>
		/// The owner of the target. Automatically set on application.
		/// <para>Does NOT update automatically! If this is desired, you can use <see cref="BuffSystem.RegisterForOwnershipChanges"/>.</para>
		/// </summary>
		public player TargetPlayer { get; set; }

		/// <summary>
		/// The remaining duration before this buff expires.
		/// </summary>
		public float Duration { get; set; }
		/// <summary>
		/// Whether this buff is beneficial or detrimental to the target.
		/// </summary>
		public bool IsBeneficial { get; set; }

		/// <summary>
		/// The buff types, used primarily for dispelling. E.g. magic, physical, undispellable, etc.
		/// </summary>
		public List<string> BuffTypes { get; set; } = new List<string>();

		/// <summary>
		/// The number of stacks of this buff currently active on the target.
		/// <para>Defaults to 1.</para>
		/// </summary>
		public int Stacks { get; set; } = 1;

		private protected string effectString;
		/// <summary>
		/// The path of the effect to use. Leave empty for no effect.
		/// <para>If changed while the buff is already active, will destroy and recreate the effect.</para>
		/// </summary>
		public string EffectString
		{
			get => this.effectString;
			set
			{
				if (this.effectString != value)
				{
					this.effectString = value;
					if (this.effect != null)
					{
						DestroyEffect(this.effect);
					}
					if (!string.IsNullOrEmpty(value))
					{
						this.effect = AddSpecialEffectTarget(value, Target, this.effectAttachmentPoint);
					}
					else
					{
						this.effect = null;
					}
				}
			}
		}

		private protected string effectAttachmentPoint = "origin";
		/// <summary>
		/// The attachment point for the effect.
		/// <para>If changed while the buff is already active, will destroy and recreate the effect at the desired attachment point.</para>
		/// <para>Defaults to origin.</para>
		/// </summary>
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
						this.effect = AddSpecialEffectTarget(this.effectString, Target, this.effectAttachmentPoint);
					}
				}
			}
		}

		/// <summary>
		/// The actual in-game effect applied on the target.
		/// </summary>
		protected effect effect;

		internal readonly int targetHandleId;

		/// <summary>
		/// Will set Caster, CastingPlayer, Target and TargetPlayer accordingly.
		/// </summary>
		public Buff(unit caster, unit target)
		{
			Caster = caster;
			CastingPlayer = GetOwningPlayer(caster);
			Target = target;
			TargetPlayer = GetOwningPlayer(target);
			this.targetHandleId = GetHandleId(target);
		}

		/// <summary>
		/// Called by the system. Do not call yourself.
		/// </summary>
		public abstract void Apply();

		/// <summary>
		/// Called by the system. Do not call yourself.
		/// </summary>
		public abstract void Action();

		/// <summary>
		/// Executes immediately upon application of the buff.
		/// </summary>
		public virtual void OnApply()
		{

		}

		/// <summary>
		/// Executes whenever this buff receives a new stack via <see cref="BuffSystem.Add(Buff, StackBehaviour)"/>.
		/// <para>By default, the stacks of <paramref name="newStack"/> are added to this buff and <see cref="StackResult.Stack"/> is returned.</para>
		/// </summary>
		public virtual StackResult OnStack(Buff newStack)
		{
			Stacks += newStack.Stacks;
			return StackResult.Stack;
		}

		/// <summary>
		/// Executes immediately after <see cref="Target"/> dies.
		/// </summary>
		/// <param name="killingBlow"></param>
		/// <returns></returns>
		public virtual void OnDeath(bool killingBlow)
		{

		}

		/// <summary>
		/// Executes when an attempt is made to dispel the target. Return false to resist the dispel.
		/// </summary>
		public virtual bool OnDispel(unit dispeller)
		{
			return true;
		}

		/// <summary>
		/// Executes when the buff is removed for any reason whatsoever.
		/// </summary>
		public virtual void OnDispose()
		{

		}

		/// <summary>
		/// Executes when the buff expires by reaching the end of its duration. Does not trigger when the buff is removed via a dispel or target dies.
		/// </summary>
		public virtual void OnExpire()
		{

		}

		/// <summary>
		/// You MUST call this method whenever you manually set <see cref="Active"/> to false.
		/// </summary>
		public void Dispose()
		{
			OnDispose();
			Active = false;

			if (this.effect != null)
			{
				DestroyEffect(this.effect);
			}

			BuffSystem.Remove(this);
		}
	}
}
