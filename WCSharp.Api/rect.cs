using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class rect : agent, IDisposable
	{
		internal rect()
		{
		}

		/// @CSharpLua.Template = "Rect({0}, {1}, {2}, {3})"
		public static extern rect Create(float minX, float minY, float maxX, float maxY);

		/// @CSharpLua.Template = "GetWorldBounds()"
		public static extern rect CreateWorldBounds();

		/// @CSharpLua.Get = "GetRectMinX({this})"
		/// @CSharpLua.Set = "SetRect({this}, {0}, GetRectMinY({this}), GetRectMaxX({this}), GetRectMaxY({this}))"
		public extern float MinX { get; set; }

		/// @CSharpLua.Get = "GetRectMinY({this})"
		/// @CSharpLua.Set = "SetRect({this}, GetRectMinX({this}), {0}, GetRectMaxX({this}), GetRectMaxY({this}))"
		public extern float MinY { get; set; }

		/// @CSharpLua.Get = "GetRectMaxX({this})"
		/// @CSharpLua.Set = "SetRect({this}, GetRectMinX({this}), GetRectMinY({this}), {0}, GetRectMaxY({this}))"
		public extern float MaxX { get; set; }

		/// @CSharpLua.Get = "GetRectMaxY({this})"
		/// @CSharpLua.Set = "SetRect({this}, GetRectMinX({this}), GetRectMinY({this}), GetRectMaxX({this}), {0})"
		public extern float MaxY { get; set; }

		/// @CSharpLua.Get = "GetRectCenterX({this})"
		/// @CSharpLua.Set = "MoveRectTo({this}, {0}, GetRectCenterY({this}))"
		public extern float CenterX { get; set; }

		/// @CSharpLua.Get = "GetRectCenterY({this})"
		/// @CSharpLua.Set = "MoveRectTo({this}, GetRectCenterX({this}), {0})"
		public extern float CenterY { get; set; }

		/// @CSharpLua.Template = "SetRect({this}, {0}, {1}, {2}, {3})"
		public extern void MoveTo(float minX, float minY, float maxX, float maxY);

		/// @CSharpLua.Template = "MoveRectTo({this}, {0}, {1})"
		public extern void MoveTo(float centerX, float centerY);

		/// @CSharpLua.Template = "EnumDestructablesInRect({this}, {0}, {1})"
		public extern void EnumerateDestructables(boolexpr filter, Action callback);

		/// @CSharpLua.Template = "EnumItemsInRect({this}, {0}, {1})"
		public extern void EnumerateItems(boolexpr filter, Action callback);

		/// @CSharpLua.Template = "AddWeatherEffect({this}, {0})"
		public extern weathereffect AddWeather(int weatherEffectId);

		/// @CSharpLua.Template = "CreateFogModifierRect({0}, {1}, {this}, {2}, {3})"
		public extern fogmodifier AddFogModifier(player player, fogstate fogstate, bool useSharedVision, bool afterUnits);

		/// @CSharpLua.Template = "SetBlightRect({0}, {this}, {1})"
		public extern void SetBlight(player player, bool addBlight);

		/// @CSharpLua.Template = "SetFogStateRect({0}, {1}, {this}, {2})"
		public extern void SetFogState(player player, fogstate fogstate, bool useSharedVision);

		/// @CSharpLua.Template = "SetDoodadAnimationRect({this}, {0}, {1}, {2})"
		public extern void SetDoodadAnimation(int doodadId, string animationName, bool animationRandom);

		/// @CSharpLua.Template = "RemoveRect({this})"
		public extern void Dispose();
	}
}
