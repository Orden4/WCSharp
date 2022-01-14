using System.Collections.Generic;
using static War3Api.Common;

namespace WCSharp.DamageControl
{
	public static class DamageConfiguration
	{
		internal static Dictionary<attacktype, Dictionary<defensetype, float>> DamageFactors { get; } = new Dictionary<attacktype, Dictionary<defensetype, float>>();
		internal static Dictionary<attacktype, float> EtherealFactors { get; } = new Dictionary<attacktype, float>
		{
			{ ConvertAttackType(7), 0f }
		};


		public static void ConfigureDamageFactor(attacktype attackType, defensetype defenseType, float factor)
		{
			DamageFactors[attackType][defenseType] = factor;
		}

		public static void ConfigureDamageFactors(attacktype attackType, List<float> factors)
		{
			var dict = DamageFactors[attackType];
			dict[DEFENSE_TYPE_LIGHT] = factors[0];
			dict[DEFENSE_TYPE_MEDIUM] = factors[1];
			dict[DEFENSE_TYPE_LARGE] = factors[2];
			dict[DEFENSE_TYPE_FORT] = factors[3];
			dict[DEFENSE_TYPE_NORMAL] = factors[4];
			dict[DEFENSE_TYPE_HERO] = factors[5];
			dict[DEFENSE_TYPE_DIVINE] = factors[6];
			dict[DEFENSE_TYPE_NONE] = factors[7];
		}

		public static void ConfigureEtherealFactor(attacktype attackType, float factor)
		{
			EtherealFactors[attackType] = factor;
		}

		public static void ConfigureEtherealFactors(List<float> factors)
		{
			EtherealFactors[ATTACK_TYPE_NORMAL] = factors[0];
			EtherealFactors[ATTACK_TYPE_MELEE] = factors[1];
			EtherealFactors[ATTACK_TYPE_PIERCE] = factors[2];
			EtherealFactors[ATTACK_TYPE_SIEGE] = factors[3];
			EtherealFactors[ATTACK_TYPE_MAGIC] = factors[4];
			EtherealFactors[ATTACK_TYPE_CHAOS] = factors[5];
			EtherealFactors[ATTACK_TYPE_HERO] = factors[6];
		}

		static DamageConfiguration()
		{
			for (var i = 0; i < 8; i++)
			{
				DamageFactors.Add(ConvertAttackType(0), new Dictionary<defensetype, float>());
			}

			ConfigureDamageFactors(ATTACK_TYPE_CHAOS, new List<float>
			{
				1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f
			});
			ConfigureDamageFactors(ATTACK_TYPE_HERO, new List<float>
			{
				1f, 1f, 1f, 0.5f, 1f, 1f, 0.05f, 1f
			});
			ConfigureDamageFactors(ATTACK_TYPE_MAGIC, new List<float>
			{
				1.25f, 0.75f, 2f, 0.35f, 1f, 0.5f, 0.05f, 1f
			});
			ConfigureDamageFactors(ATTACK_TYPE_MELEE, new List<float>
			{
				1f, 1.5f, 1f, 0.7f, 1f, 1f, 0.05f, 1f
			});
			ConfigureDamageFactors(ATTACK_TYPE_PIERCE, new List<float>
			{
				2f, 0.75f, 1f, 0.35f, 1f, 0.5f, 0.05f, 1.5f
			});
			ConfigureDamageFactors(ATTACK_TYPE_SIEGE, new List<float>
			{
				1f, 0.5f, 1f, 1.5f, 1f, 0.5f, 0.05f, 1.5f
			});
			ConfigureDamageFactors(ATTACK_TYPE_NORMAL, new List<float>
			{
				1f, 1f, 1f, 1f, 1f, 0.7f, 0.05f, 1f
			});
			ConfigureDamageFactors(ConvertAttackType(7), new List<float>
			{
				1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f
			});

			ConfigureEtherealFactors(new List<float>
			{
				0f, 0f, 0f, 1.66f, 0f, 1.66f, 0f
			});
		}
	}
}
