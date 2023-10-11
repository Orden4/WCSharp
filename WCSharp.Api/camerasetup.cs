namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class camerasetup : handle
	{
		internal camerasetup()
		{
		}

		/// @CSharpLua.Template = "CreateCameraSetup()"
		public static extern camerasetup Create();

		/// @CSharpLua.Get = "CameraSetupGetDestPositionX({this})"
		/// @CSharpLua.Set = "CameraSetupSetDestPosition({this}, {0}, CameraSetupGetDestPositionY({this}), 0)"
		public extern float X { get; set; }

		/// @CSharpLua.Get = "CameraSetupGetDestPositionY({this})"
		/// @CSharpLua.Set = "CameraSetupSetDestPosition({this}, CameraSetupGetDestPositionX({this}), {0}, 0)"
		public extern float Y { get; set; }

		/// @CSharpLua.Get = "BlzCameraSetupGetLabel({this})"
		/// @CSharpLua.Set = "BlzCameraSetupSetLabel({this}, {0})"
		public extern string Label { get; set; }

		/// @CSharpLua.Template = "CameraSetupSetDestPosition({this}, {0}, {1}, {2})"
		public extern void SetPosition(float x, float y, float duration = 0);

		/// @CSharpLua.Template = "CameraSetupApply({this}, {0}, {1})"
		public extern void Apply(bool doPan, bool panTimed);

		/// @CSharpLua.Template = "CameraSetupApplyWithZ({this}, {0})"
		public extern void ApplyWithZ(float zPositionOffset);

		/// @CSharpLua.Template = "CameraSetupApplyForceDuration({this}, {0}, {1})"
		public extern void ApplyForceDuration(bool doPan, float forceDuration);

		/// @CSharpLua.Template = "CameraSetupApplyForceDurationWithZ({this}, {0}, {1})"
		public extern void ApplyForceDurationWithZ(float zPositionOffset, float forceDuration);

		/// @CSharpLua.Template = "BlzCameraSetupApplyForceDurationSmooth({this}, {0}, {1}, {2}, {3}, {4})"
		public extern void ApplyForceDurationSmooth(bool doPan, float forcedDuration, float easeInDuration, float easeOutDuration, float smoothFactor);
	}
}
