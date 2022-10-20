namespace WCSharp.DateTime
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class PlayerProperty
	{
		/// @CSharpLua.Get = "{0}:vel().x"
		/// @CSharpLua.Set = "{0}:velset(vel: { x: {1} })"
		public float VelX { get; set; }
		/// @CSharpLua.Get = "{0}:vel().y"
		/// @CSharpLua.Set = "{0}:velset(vel: { y: {1} })"
		public float VelY { get; set; }

		/// @CSharpLua.Template = "{0}:velset(vel: {1})"
		public extern void SetVelocity(Velocity vel);

		/// @CSharpLua.Template = "{0}:velset(vel: { x: {1}, y: {2} })"
		public extern void SetVelocity(float x, float y);

		/// @CSharpLua.Template = "{0}:vel()"
		public extern Velocity GetVelocity();
	}

	/// @CSharpLua.Ignore
	public class Velocity
	{
		/// @CSharpLua.Ignore
		public int X { get; }
		/// @CSharpLua.Ignore
		public int Y { get; }
	}
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
}
