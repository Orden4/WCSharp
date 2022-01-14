using System;
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
			Duration = 1.1f;
			EffectString = @"Abilities\Spells\Human\DevotionAura\DevotionAura.mdl";
			StackBehaviour = StackBehaviour.Stack;
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

	public class MyBuff : AuraBoundBuff
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
			Console.WriteLine("expired! : " + GetUnitName(Target));
			BlzSetUnitArmor(Target, BlzGetUnitArmor(Target) - 5);
		}

		public override void OnDeath(bool killingBlow)
		{
			Console.WriteLine(killingBlow);
		}
	}
}
