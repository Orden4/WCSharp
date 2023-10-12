using System;
using System.Collections.Generic;
using WCSharp.SaveLoad;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace Source
{
	public static class SaveManager
	{
		public static Dictionary<player, MySave> SavesByPlayer { get; } = new Dictionary<player, MySave>();
		private static SaveSystem<MySave> saveSystem;

		public static void Initialize()
		{
			// Do not just copy/paste these options, you should pick your own hash and salt values
			// You can use IntelliSense to get more information about the options
			// Just know that Hash1, Hash2, Salt and SaveFolder are required
			saveSystem = new SaveSystem<MySave>(new SaveSystemOptions
			{
				Hash1 = 775807,
				Hash2 = 456023,
				Salt = "ZSLJ96ED6sPwYkQM",
				BindSavesToPlayerName = true,
				SaveFolder = "MyHeroSurvivalMap",
			});

			saveSystem.OnSaveLoaded += SaveManager_OnSaveLoaded;

			saveSystem.Load(Player(0));
			saveSystem.Load(Player(0), 2);
			saveSystem.Load(Player(0), 2);
		}

		public static void SaveManager_OnSaveLoaded(MySave save, LoadResult loadResult)
		{
			SavesByPlayer[save.GetPlayer()] = save;
			if (loadResult == LoadResult.NewSave)
			{
				// You can also set the default value of the property to this, if you want
				// This is just to illustrate why you may want to know when it is an empty save,
				// as then things like the heroes dictionary will not be created or filled.
				save.Heroes = new Dictionary<Hero, HeroData>();
				NewSave();
			}
			else
			{
				var heroData = save.Heroes[Hero.Archmage];
				heroData.Z1++;
			}

			Save(save);
		}

		public static void Save(MySave save)
		{
			saveSystem.Save(save);
			Console.WriteLine("Saved");
		}

		public static void NewSave()
		{
			var currentPlayer = Player(0);
			var pickedHero = Hero.Archmage;
			var save = SavesByPlayer[currentPlayer];
			if (!save.Heroes.TryGetValue(pickedHero, out var heroData))
			{
				heroData = new HeroData();
				save.Heroes[pickedHero] = heroData;
			}
			heroData.A = 99999999;
			heroData.B = 99999999;
			heroData.C = 99999999;
			heroData.D = 99999999;
			heroData.E = 99999999;
			heroData.F = 99999999;
			heroData.G = 99999999;
			heroData.H = 99999999;
			heroData.I = 99999999;
			heroData.J = 99999999;
			heroData.K = 99999999;
			heroData.L = 99999999;
			heroData.M = 99999999;
			heroData.N = 99999999;
			heroData.O = 99999999;
			heroData.P = 99999999;
			heroData.Q = 99999999;
			heroData.R = 99999999;
			heroData.S = 99999999;
			heroData.T = 99999999;
			heroData.U = 99999999;
			heroData.V = 99999999;
			heroData.W = 99999999;
			heroData.X = 99999999;
			heroData.Y = 99999999;
			heroData.Z = 99999999;
			heroData.Z1 = 99999999;
		}
	}
}
