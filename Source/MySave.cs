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
		public int A1 { get; set; }
		public int B1 { get; set; }
		public int C1 { get; set; }
		public int D1 { get; set; }
		public int E1 { get; set; }
		public int F1 { get; set; }
		public int G1 { get; set; }
		public int H1 { get; set; }
		public int I1 { get; set; }
		public int J1 { get; set; }
		public int K1 { get; set; }
		public int L1 { get; set; }
		public int M1 { get; set; }
		public int N1 { get; set; }
		public int O1 { get; set; }
		public int P1 { get; set; }
		public int Q1 { get; set; }
		public int R1 { get; set; }
		public int S1 { get; set; }
		public int T1 { get; set; }
		public int U1 { get; set; }
		public int V1 { get; set; }
		public int W1 { get; set; }
		public int X1 { get; set; }
		public int Y1 { get; set; }
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
