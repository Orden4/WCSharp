using System;
using System.Collections.Generic;
using Source.Buffs;
using Source.Missiles;
using WCSharp.Buffs;
using WCSharp.Events;
using WCSharp.Mazing.Cardinal;
using WCSharp.SaveLoad;
using WCSharp.Shared;
using WCSharp.Shared.Data;
using WCSharp.Shared.Extensions;
using static Constants;
using static War3Api.Common;

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

				//var list = new List<int>
				//{
				//	5
				//};
				//var a = Os.Clock();
				//for (var i = 0; i < 10000000; i++)
				//{
				//	var b = list[0];
				//	var c = list[0];
				//}
				//Console.WriteLine(Os.Clock() - a);
				//a = Os.Clock();
				//for (var i = 0; i < 10000000; i++)
				//{
				//	var x = list[0];
				//	var b = x;
				//	var c = x;
				//}
				//Console.WriteLine(Os.Clock() - a);
				//a = Os.Clock();
				//for (var i = 0; i < 10000000; i++)
				//{
				//}
				//Console.WriteLine(Os.Clock() - a);

				var group = CreateGroup();
				GroupEnumUnitsInRange(group, 0, 0, 10000, null);
				foreach (var a in group.Enumerate())
				{
					if (GetUnitTypeId(a) == FourCC("hctw") || GetUnitTypeId(a) == FourCC("hbar"))
					{
						var x = GetUnitX(a);
						var y = GetUnitY(a);
						Console.WriteLine($"{GetUnitName(a)}: ({x}, {y})");
					}
				}

				var maze = new Maze(-544f, -2272f, 13, 9);
				maze.SetWaypoints(new List<Cell>
				{
					maze.GetCellByIndex(0, 0),
					maze.GetCellByIndex(12, 0),
					maze.GetCellByIndex(0, 8)
				});
				maze.DebugDraw(@"Abilities\Weapons\FireBallMissile\FireBallMissile.mdl");

				PeriodicEvents.AddPeriodicEvent(() =>
				{
					maze.DebugDraw(@"Abilities\Weapons\FireBallMissile\FireBallMissile.mdl");
					return true;
				}, 10f);

				PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeReceivesPointOrder, () =>
				{
					var u = GetTriggerUnit();
					var o = GetIssuedOrderId();
					var x = GetOrderPointX();
					var y = GetOrderPointY();

					var a = new Unit(u);
					Console.WriteLine(a.MovementSpeed);
					a.MovementSpeed = 400;
					Console.WriteLine(a.MovementSpeed);
					a.MovementSpeed += 50;
					Console.WriteLine(a.MovementSpeed);
					Console.WriteLine(GetHandleId(a.Wc3Unit));

					if (o == 1752659063)
					{
						if (maze.WouldBlock(x, y, 2, 2))
						{
							Delay.Add(() => IssueImmediateOrderById(u, ORDER_STOP));
						}
						else
						{

						}
					}
				});

				PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeStartsBeingConstructed, () =>
				{
					new Performance().Run();
					Console.WriteLine($"{maze.Rectangle.Left}, {maze.Rectangle.Bottom}, {maze.Rectangle.Right}, {maze.Rectangle.Top}");

					var u = GetTriggerUnit();
					maze.Build(u, GetUnitX(u), GetUnitY(u), 2, 2);
				});

				var g = CreateGroup();
				GroupEnumUnitsInRect(g, Rectangle.WorldBounds.Rect, null);
				foreach (var unit in g.Enumerate())
				{
					if (GetUnitTypeId(unit) == FourCC("hfoo"))
					{
						var aura = new AuraTest(unit);
						AuraSystem.Add(aura);
					}
				}

				//SaveManager.Initialize();

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
