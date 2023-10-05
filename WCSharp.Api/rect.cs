using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class rect : agent, IDisposable
	{
		internal rect()
		{
		}

		/// @CSharpLua.Template = "rect({0}, {1}, {2}, {3})"
		public static extern rect Create(float minX, float minY, float maxX, float maxY);

		/// @CSharpLua.Template = "GetWorldBounds()"
		public static extern rect CreateWorldBounds();

		/// @CSharpLua.Get = "GetRectMinX({0})"
		/// @CSharpLua.Set = "SetRect({0}, {1}, GetRectMinY({0}), GetRectMaxX({0}), GetRectMaxY({0}))"
		public extern float MinX { get; set; }

		/// @CSharpLua.Get = "GetRectMinY({0})"
		/// @CSharpLua.Set = "SetRect({0}, GetRectMinX({0}), {1}, GetRectMaxX({0}), GetRectMaxY({0}))"
		public extern float MinY { get; set; }

		/// @CSharpLua.Get = "GetRectMaxX({0})"
		/// @CSharpLua.Set = "SetRect({0}, GetRectMinX({0}), GetRectMinY({0}), {1}, GetRectMaxY({0}))"
		public extern float MaxX { get; set; }

		/// @CSharpLua.Get = "GetRectMaxY({0})"
		/// @CSharpLua.Set = "SetRect({0}, GetRectMinX({0}), GetRectMinY({0}), GetRectMaxX({0}), {1})"
		public extern float MaxY { get; set; }

		/// @CSharpLua.Get = "GetRectCenterX({0})"
		/// @CSharpLua.Set = "MoveRectTo({0}, {1}, GetRectCenterY({0}))"
		public extern float CenterX { get; set; }

		/// @CSharpLua.Get = "GetRectCenterY({0})"
		/// @CSharpLua.Set = "MoveRectTo({0}, GetRectCenterX({0}), {1})"
		public extern float CenterY { get; set; }

		/// @CSharpLua.Template = "SetRect({0}, {1}, {2}, {3}, {4})"
		public extern void MoveTo(float minX, float minY, float maxX, float maxY);

		/// @CSharpLua.Template = "MoveRectTo({0}, {1}, {2})"
		public extern void MoveTo(float centerX, float centerY);

		/// @CSharpLua.Template = "EnumDestructablesInRect({0}, {1}, {2})"
		public extern void EnumerateDestructables(boolexpr filter, Action callback);

		/// @CSharpLua.Template = "EnumItemsInRect({0}, {1}, {2})"
		public extern void EnumerateItems(boolexpr filter, Action callback);

		/// @CSharpLua.Template = "AddWeatherEffect({0}, {1})"
		public extern weathereffect AddWeather(int weatherEffectId);

		/// @CSharpLua.Template = "CreateFogModifierRect({1}, {2}, {0}, {3}, {4})"
		public extern fogmodifier AddFogModifier(player player, fogstate fogstate, bool useSharedVision, bool afterUnits);

		/// @CSharpLua.Template = "SetBlightRect({0}, {1})"
		public extern void SetBlight(player player, bool addBlight);

		/// @CSharpLua.Template = "SetFogStateRect({1}, {2}, {0}, {3})"
		public extern void SetFogState(player player, fogstate fogstate, bool useSharedVision);

		/// @CSharpLua.Template = "SetDoodadAnimationRect({0}, {1}, {2}, {3})"
		public extern void SetDoodadAnimation(int doodadId, string animationName, bool animationRandom);

		/// @CSharpLua.Template = "RemoveRect({0})"
		public extern void Dispose();
	}
}
