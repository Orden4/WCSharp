using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class TerrainDeformation
	{
		internal TerrainDeformation()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator terraindeformation(TerrainDeformation x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator TerrainDeformation(terraindeformation x);

		/// @CSharpLua.Template = "TerrainDeformCrater({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern TerrainDeformation Crater(float x, float y, float radius, float depth, int duration, bool permanent);

		/// @CSharpLua.Template = "TerrainDeformRipple({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})"
		public static extern TerrainDeformation Ripple(float x, float y, float radius, float depth, int duration, int count, float spaceWaves, float timeWaves,
			float radiusStartPct, bool limitNeg);

		/// @CSharpLua.Template = "TerrainDeformWave({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})"
		public static extern TerrainDeformation Wave(float x, float y, float targetX, float targetY, float distance, float speed, float radius, float depth, int trailTime,
			int count);

		/// @CSharpLua.Template = "TerrainDeformWave({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern TerrainDeformation Random(float x, float y, float radius, float minDelta, float maxDelta, int duration, int updateInterval);

		/// @CSharpLua.Template = "TerrainDeformRandom()"
		public static extern void StopAll();

		/// @CSharpLua.Template = "TerrainDeformStop({0}, {1})"
		public extern void Stop(int duration);
	}
}
