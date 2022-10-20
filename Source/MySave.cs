using System.Collections.Generic;
using WCSharp.SaveLoad;

namespace Source
{
	public class HeroData
	{
		public int A { get; set; }
		public int B { get; set; }
		public int C { get; set; }
		public int D { get; set; }
		public int E { get; set; }
		public int F { get; set; }
		public int G { get; set; }
		public int H { get; set; }
		public int I { get; set; }
		public int J { get; set; }
		public int K { get; set; }
		public int L { get; set; }
		public int M { get; set; }
		public int N { get; set; }
		public int O { get; set; }
		public int P { get; set; }
		public int Q { get; set; }
		public int R { get; set; }
		public int S { get; set; }
		public int T { get; set; }
		public int U { get; set; }
		public int V { get; set; }
		public int W { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
		public int Z1 { get; set; }
	}

	public class MySave : Saveable
	{
		public Dictionary<Hero, HeroData> Heroes { get; set; }
	}

	public enum Hero
	{
		Archmage = 1,
		Blademaster = 2,
		DemonHunter = 3
	}
}
