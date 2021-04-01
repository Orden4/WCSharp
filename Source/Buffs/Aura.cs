using WCSharp.Buffs;
using static Constants;
using static War3Api.Common;

namespace Source.Buffs
{
	public class AuraTest : Aura<MyBuff>
	{
		public AuraTest(unit caster) : base(caster)
		{
			Radius = 800;
			EffectString = @"Abilities\Spells\Human\DevotionAura\DevotionAura.mdl";
			StackBehaviour = StackBehaviour.StackCaster;
		}

		protected override MyBuff CreateAuraBuff(unit unit)
		{
			return new MyBuff(Caster, unit);
		}

		protected override bool UnitFilter(unit unit)
		{
			return IsUnitAlly(unit, CastingPlayer);
		}
	}

	public class MyBuff : BoundBuff
	{
		public MyBuff(unit caster, unit target) : base(caster, target)
		{
			EffectString = @"Abilities\Spells\Other\GeneralAuraTarget\GeneralAuraTarget.mdl";
			Bind(ABILITY_MARK_AURA, BUFF_MARK);
		}

		public override void OnApply()
		{
			BlzSetUnitArmor(Target, BlzGetUnitArmor(Target) + 5);
		}

		public override void OnExpire()
		{
			BlzSetUnitArmor(Target, BlzGetUnitArmor(Target) - 5);
		}
	}
}
