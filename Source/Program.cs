using System;
using System.Collections.Generic;
using Source.Missiles;
using WCSharp.Buffs;
using WCSharp.SaveLoad;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace Source
{
	public static class Program
	{
		public static void Main()
		{
			// Delay a little since some stuff can break otherwise
			var timer = CreateTimer();
			TimerStart(timer, 0.01f, false, () =>
			{
				DestroyTimer(timer);
				Start();
			});
		}

		private static void Start()
		{
			try
			{

				//var supressDamaged = false;
				//PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeDamages, () =>
				//{
				//	//BlzSetEventDamage(0);
				//	if (supressDamaged)
				//	{
				//		Console.WriteLine($"Own damaged detected: {GetEventDamage()}");
				//		supressDamaged = false;
				//	}
				//	else
				//	{
				//		Console.WriteLine($"Unit damaged detected: {GetEventDamage()}");
				//		//supressDamaged = true;
				//		//GetTriggerUnit().Damage(GetTriggerUnit(), 5f, ATTACK_TYPE_CHAOS);
				//	}
				//});
				//PlayerUnitEvents.AddCustomEventFilter(EVENT_PLAYER_UNIT_DAMAGING, "damaging", () => GetUnitTypeId(GetTriggerUnit()));
				//PlayerUnitEvents.Register("damaging", () =>
				//{
				//	var armor = BlzGetUnitArmor(BlzGetEventDamageTarget());
				//	Console.WriteLine($"Should be: {GetEventDamage() * 2 * (1 - (armor * 0.06 / (1 + (armor * 0.06))))}");
				//	Console.WriteLine($"Damaging detected: {GetEventDamage()}");
				//}, FourCC("hfoo"));

				//PlayerUnitEvents.Register(PlayerUnitEvent.PlayerSelectsUnitType, () =>
				//{
				//	var unit = GetTriggerUnit();
				//	var now = Os.Clock();
				//	for (var i = 0; i < 100000; i++)
				//	{
				//		UnitDamageTarget(unit, unit, 0.1f, false, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS);
				//	}
				//	Console.WriteLine(Os.Clock() - now);
				//});

				//var trigger = CreateTrigger();
				//TriggerRegisterPlayerUnitEvent(trigger, Player(0), EVENT_PLAYER_UNIT_DAMAGING, null);
				////TriggerAddCondition(trigger, Filter(DealDamage));
				//TriggerAddAction(trigger, Action);


				var force = CreateForce();
				var players = new List<player>();
				for (var i = 0; i < 10; i++)
				{
					players.Add(Player(i));
					ForceAddPlayer(force, Player(i));
				}

				var p1 = Player(0);
				var a = Os.Clock();
				for (var i = 0; i < 10000000; i++)
				{
					if (BlzForceHasPlayer(force, p1))
					{

					}
				}
				Console.WriteLine(Os.Clock() - a);
				a = Os.Clock();
				for (var i = 0; i < 10000000; i++)
				{
					if (IsPlayerInForce(p1, force))
					{

					}
				}
				Console.WriteLine(Os.Clock() - a);
				a = Os.Clock();
				for (var i = 0; i < 10000000; i++)
				{
				}
				Console.WriteLine(Os.Clock() - a);

				//var group = CreateGroup();
				//GroupEnumUnitsInRange(group, 0, 0, 10000, null);
				//foreach (var a in group.ToList())
				//{
				//	if (GetUnitTypeId(a) == FourCC("hctw") || GetUnitTypeId(a) == FourCC("hbar"))
				//	{
				//		var x = GetUnitX(a);
				//		var y = GetUnitY(a);
				//		Console.WriteLine($"{GetUnitName(a)}: ({x}, {y})");
				//	}
				//}

				//var g = CreateGroup();
				//GroupEnumUnitsInRect(g, Rectangle.WorldBounds.Rect, null);
				//foreach (var unit in g.ToList())
				//{
				//	if (GetUnitTypeId(unit) == FourCC("hfoo"))
				//	{
				//		var aura = new AuraTest(unit);
				//		AuraSystem.Add(aura);
				//	}
				//}

				var x = default(WCSharp.Api.boolexpr);
				var y = default(WCSharp.Api.conditionfunc);
				var z = default(WCSharp.Api.filterfunc);
				x.Dispose();
				y.Dispose();
				z.Dispose();

				SaveManager.Initialize();

				Arcing.Initialise();
				Curving.Initialise();
				Homing.Initialise();
				Momentum.Initialise();
				Orbital.Initialise();
				Straight.Initialise();
			}
			catch (Exception ex)
			{
				DisplayTextToPlayer(GetLocalPlayer(), 0, 0, ex.Message);
			}
		}

		private static (object a, object b, object c) SomeMethod()
		{
			throw new NotImplementedException();
		}

		private class Test : Saveable { }

		private static bool DealDamage()
		{
			Action();
			return false;
		}

		private static void Action()
		{

		}

		private class Dot : AutoBuff
		{
			public Dot(unit caster, unit target) : base(caster, target)
			{
				Duration = 60f;
				Interval = 3f;
				DamagePerInterval = 5f;
				AttackType = ATTACK_TYPE_MAGIC;
				DamageType = DAMAGE_TYPE_NORMAL;
				EffectAttachmentPoint = "chest";
				EffectString = @"Abilities\Weapons\ZigguratMissile\ZigguratMissile.mdl";
			}
		}
	}

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	internal static class Os
	{
		/// @CSharpLua.Template = "os.date({0})"
		public static extern object Date(string format);

		/// @CSharpLua.Template = "os.date({0}, {1})"
		public static extern string Date(string format, int seconds);

		/// @CSharpLua.Template = "os.clock()"
		public static extern float Clock();
	}
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
}

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
public class Unit
{
	public unit Wc3Unit { get; }

	public Unit(unit unit)
	{
		Wc3Unit = unit;
	}

	/// @CSharpLua.Template = "GetUnitMoveSpeed(this.Wc3Unit)"
	private extern int GetMovementSpeed();
	/// @CSharpLua.Template = "SetUnitMoveSpeed(this.Wc3Unit, {0})"
	private extern int SetMovementSpeed(int value);
	public int MovementSpeed
	{
		get => GetMovementSpeed();
		set => SetMovementSpeed(value);
	}
}
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
