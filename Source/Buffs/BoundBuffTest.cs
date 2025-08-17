using WCSharp.Buffs;
using static Constants;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace Source.Buffs
{
	public class BoundBuffTest : BoundBuff
	{
		public BoundBuffTest(unit caster, unit target) : base(caster, target)
		{
			Interval = 1.0f;
			Duration = 10.0f;
			EffectString = @"Abilities\Spells\Human\FlameStrike\FlameStrikeDamageTarget.mdl";
			BindAura(ABILITY_MARK_AURA, BUFF_MARK);
		}

		public override void OnTick()
		{
		}
	}

	public class MyRollingBuff : RollingBuff<MyRollingBuff>
	{
		public MyRollingBuff(unit caster, unit target) : base(caster, target)
		{
			Interval = 1.0f;
			Duration = 10.0f;
			EffectString = @"Abilities\Spells\Human\FlameStrike\FlameStrikeDamageTarget.mdl";
		}

		public override void OnTick()
		{
			UnitDamageTarget(Caster, Target, Stacks * 10, true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS);
		}
	}
}
