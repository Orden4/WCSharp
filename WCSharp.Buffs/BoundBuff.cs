using System.Linq;
using WCSharp.Api;
using WCSharp.Dummies;
using WCSharp.Events;
using static WCSharp.Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// BoundBuffs have additional logic for binding the buff to an in-game buff with support of the <see cref="DummySystem"/>.
	/// <para>As a result, this buff works a little differently, and you should read the wiki in order to see how you should handle these buffs.</para>
	/// </summary>
	public class BoundBuff : Buff
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
		/// Used to prevent the buff from being immediately dropped. Intended to give some leeway for the dummy-based bind.
		/// <para>This is decreased by 1 every <see cref="PeriodicEvents.SYSTEM_INTERVAL"/>, once it becomes 0 or less it will remove this buff if the in-game buff is not present.</para>
		/// <para>Automatically set to 0 once it detects the buff on the target.</para>
		/// <para>Defaults to 8 (0.25s).</para>
		/// </summary>
		public int BindLeeway { get; set; } = 8;

		internal int buffId;
		internal int auraId;

		/// <inheritdoc/>
		public BoundBuff(unit caster, unit target) : base(caster, target)
		{
		}

		/// <summary>
		/// Will use the <see cref="DummySystem"/> to cast the given buffing ability on the target and then track it to synchronise removal.
		/// </summary>
		/// <param name="abilityId">The ability ID which applies the buff that should be tracked</param>
		/// <param name="buffId">The buff ID to track</param>
		/// <param name="orderId">The order ID of the ability to cast</param>
		/// <param name="level">The level of the ability to cast</param>
		/// <param name="dummyPlayer">Who the owner of the dummy should be set to, defaults to Neutral Passive</param>
		public void Bind(int abilityId, int buffId, int orderId, int level = 1, player dummyPlayer = null)
		{
			dummyPlayer ??= Player(PLAYER_NEUTRAL_PASSIVE);
			var dummy = DummySystem.GetDummy();
			SetUnitOwner(dummy, dummyPlayer, false);
			UnitAddAbility(dummy, abilityId);
			if (level > 1)
			{
				SetUnitAbilityLevel(dummy, abilityId, level);
			}
			IssueTargetOrderById(dummy, orderId, Target);
			DummySystem.RecycleDummy(dummy);

			this.buffId = buffId;
		}

		/// <summary>
		/// Will add the given aura to the unit if necessary and set its level accordingly. The aura will automatically be hidden from the command UI
		/// and removed when the buff is removed.
		/// </summary>
		/// <param name="auraId"></param>
		/// <param name="buffId"></param>
		/// <param name="level"></param>
		public void Bind(int auraId, int buffId, int level = 1)
		{
			if (GetUnitAbilityLevel(Target, auraId) == 0)
			{
				UnitAddAbility(Target, auraId);
			}

			SetUnitAbilityLevel(Target, auraId, level);
			BlzUnitHideAbility(Target, auraId, true);

			this.auraId = auraId;
			this.buffId = buffId;
		}

		/// <inheritdoc/>
		public sealed override void Apply()
		{
			if (!string.IsNullOrEmpty(this.effectString))
			{
				Effect = AddSpecialEffectTarget(this.effectString, Target, this.effectAttachmentPoint);
				if (this.effectScale != 1)
				{
					BlzSetSpecialEffectScale(Effect, this.effectScale);
				}
			}

			Disposed = false;
			IntervalLeft = Interval;
			OnApply();
		}

		/// <inheritdoc/>
		public sealed override void Action()
		{
			if (BindLeeway <= 0)
			{
				if (GetUnitAbilityLevel(Target, this.buffId) == 0)
				{
					Active = false;
					return;
				}
			}
			else
			{
				BindLeeway--;
			}

			if (Interval > 0)
			{
				while (IntervalLeft <= PeriodicEvents.SYSTEM_INTERVAL)
				{
					IntervalLeft += Interval;
					OnTick();
				}

				IntervalLeft -= PeriodicEvents.SYSTEM_INTERVAL;
			}

			if (Duration <= PeriodicEvents.SYSTEM_INTERVAL)
			{
				Active = false;
				OnExpire();
			}
			else
			{
				Duration -= PeriodicEvents.SYSTEM_INTERVAL;
			}
		}

		/// <summary>
		/// Executes every <see cref="Interval"/>.
		/// </summary>
		public virtual void OnTick()
		{

		}

		/// <summary>
		/// Executes whenever this buff receives a new stack via <see cref="BuffSystem.Add(Buff, StackBehaviour)"/>.
		/// <para>By default, BoundBuff will return <see cref="StackResult.Consume"/>.</para>
		/// </summary>
		public override StackResult OnStack(Buff newStack)
		{
			return StackResult.Consume;
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

			if (this.auraId > 0)
			{
				if (BuffSystem.GetBuffsOnUnit(Target).OfType<BoundBuff>().All(x => x.auraId != this.auraId))
				{
					UnitRemoveAbility(Target, this.auraId);
					UnitRemoveAbility(Target, this.buffId);
				}
			}
			else if (BuffSystem.GetBuffsOnUnit(Target).OfType<BoundBuff>().All(x => x.buffId != this.buffId))
			{
				UnitRemoveAbility(Target, this.buffId);
			}
		}
	}
}
