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

		#region Field editing
		/// @CSharpLua.Get = "CameraSetupGetField({this}, CAMERA_FIELD_TARGET_DISTANCE)"
		/// @CSharpLua.Set = "CameraSetupSetField({this}, CAMERA_FIELD_TARGET_DISTANCE, {0}, 0)"
		public extern float TargetDistance { get; set; }
		/// @CSharpLua.Template = "CameraSetupSetField({this}, CAMERA_FIELD_TARGET_DISTANCE, {0}, {1})"
		public extern void SetTargetDistance(float value, float duration = 0);

		/// @CSharpLua.Get = "CameraSetupGetField({this}, CAMERA_FIELD_FARZ)"
		/// @CSharpLua.Set = "CameraSetupSetField({this}, CAMERA_FIELD_FARZ, {0}, 0)"
		public extern float FarZ { get; set; }
		/// @CSharpLua.Template = "CameraSetupSetField({this}, CAMERA_FIELD_FARZ, {0}, {1})"
		public extern void SetFarZ(float value, float duration = 0);

		/// @CSharpLua.Get = "CameraSetupGetField({this}, CAMERA_FIELD_ANGLE_OF_ATTACK)"
		/// @CSharpLua.Set = "CameraSetupSetField({this}, CAMERA_FIELD_ANGLE_OF_ATTACK, {0}, 0)"
		public extern float AngleOfAttack { get; set; }
		/// @CSharpLua.Template = "CameraSetupSetField({this}, CAMERA_FIELD_ANGLE_OF_ATTACK, {0}, {1})"
		public extern void SetAngleOfAttack(float value, float duration = 0);

		/// @CSharpLua.Get = "CameraSetupGetField({this}, CAMERA_FIELD_FIELD_OF_VIEW)"
		/// @CSharpLua.Set = "CameraSetupSetField({this}, CAMERA_FIELD_FIELD_OF_VIEW, {0}, 0)"
		public extern float FieldOfView { get; set; }
		/// @CSharpLua.Template = "CameraSetupSetField({this}, CAMERA_FIELD_FIELD_OF_VIEW, {0}, {1})"
		public extern void SetFieldOfView(float value, float duration = 0);

		/// @CSharpLua.Get = "CameraSetupGetField({this}, CAMERA_FIELD_ROLL)"
		/// @CSharpLua.Set = "CameraSetupSetField({this}, CAMERA_FIELD_ROLL, {0}, 0)"
		public extern float Roll { get; set; }
		/// @CSharpLua.Template = "CameraSetupSetField({this}, CAMERA_FIELD_ROLL, {0}, {1})"
		public extern void SetRoll(float value, float duration = 0);

		/// @CSharpLua.Get = "CameraSetupGetField({this}, CAMERA_FIELD_ROTATION)"
		/// @CSharpLua.Set = "CameraSetupSetField({this}, CAMERA_FIELD_ROTATION, {0}, 0)"
		public extern float Rotation { get; set; }
		/// @CSharpLua.Template = "CameraSetupSetField({this}, CAMERA_FIELD_ROTATION, {0}, {1})"
		public extern void SetRotation(float value, float duration = 0);

		/// @CSharpLua.Get = "CameraSetupGetField({this}, CAMERA_FIELD_ZOFFSET)"
		/// @CSharpLua.Set = "CameraSetupSetField({this}, CAMERA_FIELD_ZOFFSET, {0}, 0)"
		public extern float ZOffset { get; set; }
		/// @CSharpLua.Template = "CameraSetupSetField({this}, CAMERA_FIELD_ZOFFSET, {0}, {1})"
		public extern void SetZOffet(float value, float duration = 0);

		/// @CSharpLua.Get = "CameraSetupGetField({this}, CAMERA_FIELD_NEARZ)"
		/// @CSharpLua.Set = "CameraSetupSetField({this}, CAMERA_FIELD_NEARZ, {0}, 0)"
		public extern float NearZ { get; set; }
		/// @CSharpLua.Template = "CameraSetupSetField({this}, CAMERA_FIELD_NEARZ, {0}, {1})"
		public extern void SetNearZ(float value, float duration = 0);

		/// @CSharpLua.Get = "CameraSetupGetField({this}, CAMERA_FIELD_LOCAL_PITCH)"
		/// @CSharpLua.Set = "CameraSetupSetField({this}, CAMERA_FIELD_LOCAL_PITCH, {0}, 0)"
		public extern float LocalPitch { get; set; }
		/// @CSharpLua.Template = "CameraSetupSetField({this}, CAMERA_FIELD_LOCAL_PITCH, {0}, {1})"
		public extern void SetLocalPitch(float value, float duration = 0);

		/// @CSharpLua.Get = "CameraSetupGetField({this}, CAMERA_FIELD_LOCAL_YAW)"
		/// @CSharpLua.Set = "CameraSetupSetField({this}, CAMERA_FIELD_LOCAL_YAW, {0}, 0)"
		public extern float LocalYaw { get; set; }
		/// @CSharpLua.Template = "CameraSetupSetField({this}, CAMERA_FIELD_LOCAL_YAW, {0}, {1})"
		public extern void SetLocalYaw(float value, float duration = 0);

		/// @CSharpLua.Get = "CameraSetupGetField({this}, CAMERA_FIELD_LOCAL_ROLL)"
		/// @CSharpLua.Set = "CameraSetupSetField({this}, CAMERA_FIELD_LOCAL_ROLL, {0}, 0)"
		public extern float LocalRoll { get; set; }
		/// @CSharpLua.Template = "CameraSetupSetField({this}, CAMERA_FIELD_LOCAL_ROLL, {0}, {1})"
		public extern void SetLocalRoll(float value, float duration = 0);
		#endregion
	}
}
