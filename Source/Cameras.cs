using static War3Api.Common;

public static class Cameras
{
	public static readonly camerasetup Camera_001 = CreateCameraSetup();
	public static readonly camerasetup Camera_001_Copy = CreateCameraSetup();


#pragma warning disable IDE0052 // Remove unread private members
	private static readonly object initialiser = Initialise();
#pragma warning restore IDE0052 // Remove unread private members
	private static object Initialise()
	{
		CameraSetupSetDestPosition(Camera_001, 2.5177758E-05f, -576f, 0);
		CameraSetupSetField(Camera_001, CAMERA_FIELD_ZOFFSET, 0f, 0);
		CameraSetupSetField(Camera_001, CAMERA_FIELD_ROTATION, 90f, 0);
		CameraSetupSetField(Camera_001, CAMERA_FIELD_ANGLE_OF_ATTACK, 304f, 0);
		CameraSetupSetField(Camera_001, CAMERA_FIELD_TARGET_DISTANCE, 1650f, 0);
		CameraSetupSetField(Camera_001, CAMERA_FIELD_ROLL, 0f, 0);
		CameraSetupSetField(Camera_001, CAMERA_FIELD_FIELD_OF_VIEW, 70f, 0);
		CameraSetupSetField(Camera_001, CAMERA_FIELD_FARZ, 5000f, 0);
		CameraSetupSetField(Camera_001, CAMERA_FIELD_NEARZ, 16f, 0);
		CameraSetupSetField(Camera_001, CAMERA_FIELD_LOCAL_PITCH, 0f, 0);
		CameraSetupSetField(Camera_001, CAMERA_FIELD_LOCAL_YAW, 0f, 0);
		CameraSetupSetField(Camera_001, CAMERA_FIELD_LOCAL_ROLL, 0f, 0);
		CameraSetupSetDestPosition(Camera_001_Copy, -444.10385f, -616.451f, 0);
		CameraSetupSetField(Camera_001_Copy, CAMERA_FIELD_ZOFFSET, 0f, 0);
		CameraSetupSetField(Camera_001_Copy, CAMERA_FIELD_ROTATION, 90f, 0);
		CameraSetupSetField(Camera_001_Copy, CAMERA_FIELD_ANGLE_OF_ATTACK, 304f, 0);
		CameraSetupSetField(Camera_001_Copy, CAMERA_FIELD_TARGET_DISTANCE, 1650f, 0);
		CameraSetupSetField(Camera_001_Copy, CAMERA_FIELD_ROLL, 0f, 0);
		CameraSetupSetField(Camera_001_Copy, CAMERA_FIELD_FIELD_OF_VIEW, 70f, 0);
		CameraSetupSetField(Camera_001_Copy, CAMERA_FIELD_FARZ, 5000f, 0);
		CameraSetupSetField(Camera_001_Copy, CAMERA_FIELD_NEARZ, 16f, 0);
		CameraSetupSetField(Camera_001_Copy, CAMERA_FIELD_LOCAL_PITCH, 0f, 0);
		CameraSetupSetField(Camera_001_Copy, CAMERA_FIELD_LOCAL_YAW, 0f, 0);
		CameraSetupSetField(Camera_001_Copy, CAMERA_FIELD_LOCAL_ROLL, 0f, 0);
		return null;
	}
}