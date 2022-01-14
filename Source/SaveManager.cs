using System.Collections.Generic;
using WCSharp.SaveLoad;
using WCSharp.Shared;
using static War3Api.Common;

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
				SaveFolder = "MyHeroSurvivalMap"
			});

			saveSystem.OnSaveLoaded += SaveManager_OnSaveLoaded;

			saveSystem.Load(Player(0));
		}

		public static void SaveManager_OnSaveLoaded(MySave save, bool isEmptySave)
		{
			SavesByPlayer[save.GetPlayer()] = save;
			if (isEmptySave)
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
				Util.Debug(heroData.A);
				Util.Debug(heroData.B);
				Util.Debug(heroData.C);
				Util.Debug(heroData.D);
				Util.Debug(heroData.E);
				Util.Debug(heroData.F);
				Util.Debug(heroData.G);
				Util.Debug(heroData.H);
				Util.Debug(heroData.I);
				Util.Debug(heroData.J);
				Util.Debug(heroData.K);
				Util.Debug(heroData.L);
				Util.Debug(heroData.M);
				Util.Debug(heroData.N);
				Util.Debug(heroData.O);
				Util.Debug(heroData.P);
				Util.Debug(heroData.Q);
				Util.Debug(heroData.R);
				Util.Debug(heroData.S);
				Util.Debug(heroData.T);
				Util.Debug(heroData.U);
				Util.Debug(heroData.V);
				Util.Debug(heroData.W);
				Util.Debug(heroData.X);
				Util.Debug(heroData.Y);
				Util.Debug(heroData.Z);
				Util.Debug(heroData.A1);
				Util.Debug(heroData.B1);
				Util.Debug(heroData.C1);
				Util.Debug(heroData.D1);
				Util.Debug(heroData.E1);
				Util.Debug(heroData.F1);
				Util.Debug(heroData.G1);
				Util.Debug(heroData.H1);
				Util.Debug(heroData.I1);
				Util.Debug(heroData.J1);
				Util.Debug(heroData.K1);
				Util.Debug(heroData.L1);
				Util.Debug(heroData.M1);
				Util.Debug(heroData.N1);
				Util.Debug(heroData.O1);
				Util.Debug(heroData.P1);
				Util.Debug(heroData.Q1);
				Util.Debug(heroData.R1);
				Util.Debug(heroData.S1);
				Util.Debug(heroData.T1);
				Util.Debug(heroData.U1);
				Util.Debug(heroData.V1);
				Util.Debug(heroData.W1);
				Util.Debug(heroData.X1);
				Util.Debug(heroData.Y1);
				Util.Debug(heroData.Z1);
				Util.Debug("done loading");
			}
		}

		public static void Save(MySave save)
		{
			saveSystem.Save(save);
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
			heroData.A1 = 99999999;
			heroData.B1 = 99999999;
			heroData.C1 = 99999999;
			heroData.D1 = 99999999;
			heroData.E1 = 99999999;
			heroData.F1 = 99999999;
			heroData.G1 = 99999999;
			heroData.H1 = 99999999;
			heroData.I1 = 99999999;
			heroData.J1 = 99999999;
			heroData.K1 = 99999999;
			heroData.L1 = 99999999;
			heroData.M1 = 99999999;
			heroData.N1 = 99999999;
			heroData.O1 = 99999999;
			heroData.P1 = 99999999;
			heroData.Q1 = 99999999;
			heroData.R1 = 99999999;
			heroData.S1 = 99999999;
			heroData.T1 = 99999999;
			heroData.U1 = 99999999;
			heroData.V1 = 99999999;
			heroData.W1 = 99999999;
			heroData.X1 = 99999999;
			heroData.Y1 = 99999999;
			heroData.Z1 = 99999999;
			Save(save);
			Util.Debug("saved");
		}
	}
}
