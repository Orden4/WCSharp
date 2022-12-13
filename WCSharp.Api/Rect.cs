using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Rect : Agent, IDisposable
	{
		internal Rect()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator rect(Rect x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Rect(rect x);

		/// @CSharpLua.Template = "Rect({0}, {1}, {2}, {3})"
		public static extern Region Create(float minX, float minY, float maxX, float maxY);

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
		public extern void EnumerateDestructables(BoolExpr filter, Action callback);

		/// @CSharpLua.Template = "EnumItemsInRect({0}, {1}, {2})"
		public extern void EnumerateItems(BoolExpr filter, Action callback);

		/// @CSharpLua.Template = "AddWeatherEffect({0}, {1})"
		public extern WeatherEffect AddWeather(int weatherEffectId);

		/// @CSharpLua.Template = "RemoveRect({0})"
		public extern void Dispose();
	}
}
