using System.Collections.Generic;
using System.Linq;
using WCSharp.Events;
using WCSharp.Utils.Extensions;
using static War3Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// A specialized buff for handling multiple underlying buffs, each with their own duration. The buff will tick only once, but the durations of all underlying buffs are managed individually.
	/// </summary>
	/// <typeparam name="T">This should be the type implementing this abstract.</typeparam>
	public abstract class RollingBuff<T> : Buff
		where T : RollingBuff<T>
	{
		/// <summary>
		/// The time, in seconds, remaining until the next tick.
		/// </summary>
		public float IntervalLeft { get; set; }
		/// <summary>
		/// The time, in seconds, between each tick.
		/// </summary>
		public float Interval { get; set; }
		/// <summary>
		/// Whether the current instance is the main stack (i.e. the instance that manages underlying instances).
		/// </summary>
		public bool IsMainStack { get; private set; }

		private List<T> buffs;

		/// <summary>
		/// All buffs contained in this stack.
		/// <para>Note that this is only filled for the main stack.</para>
		/// </summary>
		public IEnumerable<T> Buffs => this.buffs ?? Enumerable.Empty<T>();

		/// <inheritdoc/>
		public RollingBuff(unit caster, unit target) : base(caster, target)
		{
		}

		/// <summary>
		/// Executes whenever this buff receives a new stack via <see cref="BuffSystem.Add(Buff, StackBehaviour)"/>.
		/// When overriding this method, you should always invoke base.OnStack(newStack).
		/// </summary>
		public override StackResult OnStack(Buff newStack)
		{
			var buff = (T)newStack;
			this.buffs.Add(buff);
			Stacks += buff.Stacks;
			return StackResult.Stack;
		}

		/// <inheritdoc/>
		public sealed override void Apply()
		{
			if (!string.IsNullOrEmpty(this.effectString))
			{
				Effect = AddSpecialEffectTarget(this.effectString, Target, EffectAttachmentPoint);
				if (this.effectScale != 1)
				{
					BlzSetSpecialEffectScale(Effect, this.effectScale);
				}
			}

			IsMainStack = true;
			this.buffs = new List<T>
			{
				(T)this
			};
			OnApply();
		}

		/// <inheritdoc/>
		public sealed override void Action()
		{
			if (!UnitAlive(Target))
			{
				OnDeath(false);
				Active = false;
				return;
			}

			if (IntervalLeft <= PeriodicEvents.SYSTEM_INTERVAL)
			{
				IntervalLeft = Interval;
				OnTick();
				if (!UnitAlive(Target))
				{
					OnDeath(true);
				}
			}

			IntervalLeft -= PeriodicEvents.SYSTEM_INTERVAL;

			this.buffs.IterateWithRemoval(x =>
			{
				if (x.Duration <= PeriodicEvents.SYSTEM_INTERVAL)
				{
					Stacks -= x.Stacks;
					x.OnExpire();
					x.OnDispose();
					return false;
				}
				else
				{
					x.Duration -= PeriodicEvents.SYSTEM_INTERVAL;
					return true;
				}
			});

			if (this.buffs.Count == 0)
			{
				OnExpire();
				Active = false;
			}
			else
			{
				Duration = this.buffs.Max(x => x.Duration);
			}
		}

		/// <summary>
		/// Executes whenever a stack expires (executed from the main stack).
		/// </summary>
		/// <param name="expiredStack">The stack that expired.</param>
		public virtual void OnExpireStack(T expiredStack)
		{

		}

		/// <summary>
		/// Executes every <see cref="Interval"/>.
		/// </summary>
		public virtual void OnTick()
		{

		}

		/// <inheritdoc/>
		public sealed override void Dispose()
		{
			OnDispose();

			if (Effect != null)
			{
				DestroyEffect(Effect);
			}

			BuffSystem.Remove(this);
		}
	}
}
