using System.Linq;
using WCSharp.Dummies;
using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// BoundBuffs have additional logic for binding the buff to an in-game buff with support of the <see cref="DummySystem"/>.
	/// <para>As a result, this buff works a little differently, and you should read the wiki in order to see how you should handle these buffs.</para>
	/// </summary>
	public class BoundBuff : Buff
	{
		/// <summary>
		/// The time, in seconds, between each tick.
		/// </summary>
		public float Interval { get; set; }
		/// <summary>
		/// How many ticks have occurred, according to the interval.
		/// <para>Automatically incremented before each call to <see cref="OnTick"/>.</para>
		/// </summary>
		public int TickNumber { get; set; }

		internal bool IsBound { get; set; }
		internal int BuffId { get; set; }

		public BoundBuff(unit caster, unit target) : base(caster, target)
		{
		}

		public void Bind(int abilityId, int buffId, int orderId, int level = 1, player dummyPlayer = null)
		{
			dummyPlayer ??= Player(PLAYER_NEUTRAL_PASSIVE);
			var dummy = DummySystem.GetDummy();
			SetUnitOwner(dummy, dummyPlayer, true);
			UnitAddAbility(dummy, abilityId);
			SetUnitAbilityLevel(dummy, abilityId, level);
			IssueTargetOrderById(dummy, orderId, Target);
			DummySystem.RecycleDummy(dummy);

			BuffId = buffId;
			IsBound = GetUnitAbilityLevel(Target, BuffId) > 0;
		}

		public sealed override void Apply()
		{
			if (!string.IsNullOrEmpty(this.effectString))
			{
				this.effect = AddSpecialEffectTarget(this.effectString, Target, EffectAttachmentPoint);
			}

			OnApply();
		}

		public sealed override void Action()
		{
			if (!UnitAlive(Target))
			{
				OnDeath(false);
				Dispose();
				return;
			}

			if (IsBound)
			{
				if (GetUnitAbilityLevel(Target, BuffId) == 0)
				{
					Dispose();
					return;
				}
			}
			else
			{
				IsBound = true;
			}

			Duration += PeriodicEvents.SYSTEM_INTERVAL;
			if (Interval > 0 && Duration >= (TickNumber + 1) * Interval)
			{
				TickNumber++;
				OnTick();
				if (!UnitAlive(Target))
				{
					OnDeath(true);
					Dispose();
					return;
				}
			}
		}

		/// <summary>
		/// Executes every <see cref="Interval"/>.
		/// </summary>
		public virtual void OnTick()
		{

		}

		public override StackResult OnStack(Buff newStack)
		{
			return StackResult.Consume;
		}

		public sealed override void Dispose()
		{
			OnDispose();
			Active = false;

			if (this.effect != null)
			{
				DestroyEffect(this.effect);
			}

			BuffSystem.Remove(this);

			if (UnitAlive(Target) && BuffSystem.GetBuffsOnUnit(Target).OfType<BoundBuff>().All(x => x.BuffId != BuffId))
			{
				UnitRemoveAbility(Target, BuffId);
			}
		}
	}
}
