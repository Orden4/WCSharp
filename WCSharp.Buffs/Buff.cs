using System;
using System.Collections.Generic;
using WCSharp.Api;
using WCSharp.Events;
using static WCSharp.Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// The most basic buff implementation, with almost all logic undefined.
	/// <para>It is recommended to use one of the more concrete types instead, such as <see cref="PassiveBuff"/>.</para>
	/// </summary>
	public abstract class Buff
	{
		/// <summary>
		/// Indicates the active state of this buff. Setting this to false will cause it to be removed on the next update cycle (at most <see cref="PeriodicEvents.SYSTEM_INTERVAL"/> later).
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
		/// The buff types, used primarily for dispelling. e.g. magic, physical, undispellable, etc.
		/// </summary>
		public List<string> BuffTypes { get; set; } = new List<string>();

		/// <summary>
		/// The number of stacks of this buff currently active on the target.
		/// <para>Defaults to 1.</para>
		/// </summary>
		public int Stacks { get; set; } = 1;

		private protected string effectString;
		/// <summary>
		/// The path of the effect to use.
		/// <para>If null, no effect will be created.</para>
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
					if (Active)
					{
						if (Effect != null)
						{
							DestroyEffect(Effect);
						}
						if (value != null)
						{
							Effect = AddSpecialEffectTarget(value, Target, this.effectAttachmentPoint);
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
					if (Effect != null)
					{
						DestroyEffect(Effect);
						Effect = AddSpecialEffectTarget(this.effectString, Target, this.effectAttachmentPoint);
						if (this.effectScale != 1)
						{
							BlzSetSpecialEffectScale(Effect, this.effectScale);
						}
					}
				}
			}
		}

		/// <summary>
		/// Internal effect scale. Used only when there is no effect present yet.
		/// </summary>
		private protected float effectScale = 1.0f;
		/// <summary>
		/// The effect scale of the missile.
		/// <para>If modified mid-flight, automatically modifies the missile.</para>
		/// </summary>
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

		/// <summary>
		/// The effect being used by the missile. Creation of the effect should be done by setting <see cref="EffectString"/>, not by setting this property.
		/// </summary>
		public effect Effect { get; protected set; }

		internal bool Disposed { get; set; }

		/// <summary>
		/// Will set Caster, CastingPlayer, Target and TargetPlayer accordingly.
		/// </summary>
		public Buff(unit caster, unit target)
		{
			Caster = caster;
			CastingPlayer = GetOwningPlayer(caster);
			Target = target;
			TargetPlayer = GetOwningPlayer(target);
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
			Duration = Math.Max(Duration, newStack.Duration);
			return StackResult.Stack;
		}

		/// <summary>
		/// Executes immediately after <see cref="Target"/> dies.
		/// <para>Note: <paramref name="killingBlow"/> will be true if the unit dies while the buffs actions are being evaluated.
		/// It may not be directly responsible for the death due to asynchronous events.</para>
		/// </summary>
		/// <param name="killingBlow"></param>
		/// <returns></returns>
		public virtual void OnDeath(bool killingBlow)
		{

		}

		/// <summary>
		/// Executes when an attempt is made to dispel the target. Return the number of dispel charges consmed.
		/// <para>If after this method is called the Stacks is at 0, the buff is automatically disposed.</para>
		/// </summary>
		public virtual int OnDispel(unit dispeller, int dispelCharges)
		{
			var stacksToDispel = Math.Min(Stacks, dispelCharges);
			Stacks -= stacksToDispel;
			return stacksToDispel;
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
		/// Will instantly remove this buff from the unit, including calling <see cref="OnDispose"/> and any other relevant steps.
		/// <para>It's recommended to just set <see cref="Active"/> to false unless the removal should not be delayed for some reason.</para>
		/// </summary>
		public void RemoveInstantly()
		{
			if (Active)
			{
				Active = false;
				Disposed = true;
				Dispose();
			}
		}

		/// <summary>
		/// Automatically called after <see cref="Active"/> is set to false.
		/// <para>Automatically called by the system. Do not call yourself.</para>
		/// </summary>
		public abstract void Dispose();
	}
}
