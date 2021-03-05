using static War3Api.Common;

namespace WCSharp.Natives
{
	public enum Race
	{
		Human = 1,
		Orc = 2,
		Undead = 3,
		NightElf = 4,
		Demon = 5,
		Other = 7
	}

	public static class RaceExtensions
	{
		internal static Race GetRace(this race race)
		{
			if (race == RACE_HUMAN)
			{
				return Race.Human;
			}
			else if (race == RACE_ORC)
			{
				return Race.Orc;
			}
			else if (race == RACE_UNDEAD)
			{
				return Race.Undead;
			}
			else if (race == RACE_NIGHTELF)
			{
				return Race.NightElf;
			}
			else if (race == RACE_DEMON)
			{
				return Race.Demon;
			}
			else if (race == RACE_OTHER)
			{
				return Race.Other;
			}
			else
			{
				return default;
			}
		}

		internal static race GetRace(this Race race)
		{
			return ConvertRace((int)race);
		}
	}
}
