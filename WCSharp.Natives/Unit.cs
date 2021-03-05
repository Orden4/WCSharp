using static War3Api.Common;

namespace WCSharp.Natives
{
	public class Unit
	{
		internal readonly unit unit;

		public static implicit operator unit(Unit u)
		{
			return u.unit;
		}

		public static implicit operator Unit(unit u)
		{
			return new Unit(u);
		}

		public float Life
		{
			get => GetUnitState(this.unit, UNIT_STATE_LIFE);
			set => SetUnitState(this.unit, UNIT_STATE_LIFE, value);
		}

		public float Mana
		{
			get => GetUnitState(this.unit, UNIT_STATE_MANA);
			set => SetUnitState(this.unit, UNIT_STATE_MANA, value);
		}

		public float MaxLife
		{
			get => GetUnitState(this.unit, UNIT_STATE_MAX_LIFE);
			set => SetUnitState(this.unit, UNIT_STATE_MAX_LIFE, value);
		}

		public float MaxMana
		{
			get => GetUnitState(this.unit, UNIT_STATE_MAX_MANA);
			set => SetUnitState(this.unit, UNIT_STATE_MAX_MANA, value);
		}

		public float X
		{
			get => GetUnitX(this.unit);
			set => SetUnitX(this.unit, value);
		}

		public float Y
		{
			get => GetUnitY(this.unit);
			set => SetUnitY(this.unit, value);
		}

		public float Facing
		{
			get => GetUnitFacing(this.unit);
			set => SetUnitFacing(this.unit, value);
		}

		public float MoveSpeed
		{
			get => GetUnitMoveSpeed(this.unit);
			set => SetUnitMoveSpeed(this.unit, value);
		}

		public float DefaultMoveSpeed => GetUnitDefaultMoveSpeed(this.unit);

		public float FlyHeight
		{
			get => GetUnitFlyHeight(this.unit);
			set => SetUnitFlyHeight(this.unit, value, 0);
		}

		public float DefaultFlyHeight => GetUnitDefaultFlyHeight(this.unit);

		public float TurnSpeed
		{
			get => GetUnitTurnSpeed(this.unit);
			set => SetUnitTurnSpeed(this.unit, value);
		}

		public float DefaultTurnSpeed => GetUnitDefaultTurnSpeed(this.unit);

		public float PropWindow
		{
			get => GetUnitPropWindow(this.unit);
			set => SetUnitPropWindow(this.unit, value);
		}

		public float DefaultPropWindow => GetUnitDefaultPropWindow(this.unit);

		public float AcquireRange
		{
			get => GetUnitAcquireRange(this.unit);
			set => SetUnitAcquireRange(this.unit, value);
		}

		public float DefaultAcquireRange => GetUnitDefaultAcquireRange(this.unit);

		public Player Owner
		{
			get => new Player(GetOwningPlayer(this.unit));
			set => SetUnitOwner(this.unit, value.player, true);
		}

		public int XP
		{
			get => GetHeroXP(this.unit);
			set => SetHeroXP(this.unit, value, true);
		}

		public int SkillPoints
		{
			get => GetHeroSkillPoints(this.unit);
			set => UnitModifySkillPoints(this.unit, value - GetHeroSkillPoints(this.unit));
		}

		public int Level
		{
			get => GetHeroLevel(this.unit);
			set => SetHeroLevel(this.unit, value, true);
		}

		public int Strength => GetHeroStr(this.unit, true);

		public int BaseStrength
		{
			get => GetHeroStr(this.unit, false);
			set => SetHeroStr(this.unit, value - GetHeroStr(this.unit, false), true);
		}

		public int Agility => GetHeroAgi(this.unit, true);

		public int BaseAgility
		{
			get => GetHeroAgi(this.unit, false);
			set => SetHeroAgi(this.unit, value - GetHeroAgi(this.unit, false), true);
		}

		public int Intelligence => GetHeroInt(this.unit, true);

		public int BaseIntelligence
		{
			get => GetHeroInt(this.unit, false);
			set => SetHeroInt(this.unit, value - GetHeroInt(this.unit, false), true);
		}

		public bool Paused
		{
			get => IsUnitPaused(this.unit);
			set => PauseUnit(this.unit, value);
		}

		public bool Hidden
		{
			get => IsUnitHidden(this.unit);
			set => ShowUnit(this.unit, value);
		}

		public bool Invulnerable
		{
			get => BlzIsUnitInvulnerable(this.unit);
			set => SetUnitInvulnerable(this.unit, value);
		}

		public int CustomValue
		{
			get => GetUnitUserData(this.unit);
			set => SetUnitUserData(this.unit, value);
		}

		public string Name => GetUnitName(this.unit);
		public string HeroName => GetHeroProperName(this.unit);
		public bool Illusion => IsUnitIllusion(this.unit);
		public bool Loaded => IsUnitLoaded(this.unit);
		public int UnitType => GetUnitTypeId(this.unit);
		public bool IsHero => IsHeroUnitId(GetUnitTypeId(this.unit));
		public int FoodUsed => GetUnitFoodUsed(this.unit);
		public int FoodMade => GetUnitFoodMade(this.unit);

		public bool Sleeping
		{
			get => UnitIsSleeping(this.unit);
			set
			{
				if (value)
				{
					UnitAddSleep(this.unit, true);
				}
				else
				{
					UnitWakeUp(this.unit);
				}
			}
		}

		public float WaygateDestinationX
		{
			get => WaygateGetDestinationX(this.unit);
			set => WaygateSetDestination(this.unit, value, WaygateGetDestinationY(this.unit));
		}

		public float WaygateDestinationY
		{
			get => WaygateGetDestinationY(this.unit);
			set => WaygateSetDestination(this.unit, WaygateGetDestinationY(this.unit), value);
		}

		public bool WaygateActive
		{
			get => WaygateIsActive(this.unit);
			set => WaygateActivate(this.unit, value);
		}

		public int ResourceAmount
		{
			get => GetResourceAmount(this.unit);
			set => SetResourceAmount(this.unit, value);
		}

		internal Unit(unit unit)
		{
			this.unit = unit;
			Unit u = unit;
		}

		public void Kill()
		{
			KillUnit(this.unit);
		}

		public void Remove()
		{
			RemoveUnit(this.unit);
		}

		public void Revive(float x, float y, bool showEyeCandy = true)
		{
			ReviveHero(this.unit, x, y, showEyeCandy);
		}

		public void ResetCooldown()
		{
			UnitResetCooldown(this.unit);
		}
	}
}
