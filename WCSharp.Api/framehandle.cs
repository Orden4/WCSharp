using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class framehandle : handle, IDisposable
	{
		internal framehandle()
		{
		}

		/// @CSharpLua.Template = "BlzCreateFrame({0}, {1}, {2}, {3})"
		public static extern framehandle Create(string name, framehandle owner, int priority, int createContext);
		/// @CSharpLua.Template = "BlzCreateFrameByType({0}, {1}, {2}, {3}, {4})"
		public static extern framehandle Create(string typeName, string name, framehandle owner, string inherits, int createContext);
		/// @CSharpLua.Template = "BlzCreateSimpleFrame({0}, {1}, {2})"
		public static extern framehandle CreateSimple(string name, framehandle owner, int createContext);
		/// @CSharpLua.Template = "BlzGetOriginFrame({0}, {1})"
		public static extern framehandle Get(originframetype frameType, int index);
		/// @CSharpLua.Template = "BlzGetFrameByName({0}, {1})"
		public static extern framehandle Get(string name, int createContext);

		/// @CSharpLua.Get = "BlzFrameIsVisible({this})"
		/// @CSharpLua.Set = "BlzFrameSetVisible({this}, {0})"
		public extern bool Visible { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetText({this})"
		/// @CSharpLua.Set = "BlzFrameSetText({this}, {0})"
		public extern string Text { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetTextSizeLimit({this})"
		/// @CSharpLua.Set = "BlzFrameSetTextSizeLimit({this}, {0})"
		public extern int TextSizeLimit { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetEnable({this})"
		/// @CSharpLua.Set = "BlzFrameSetEnable({this}, {0})"
		public extern bool Enabled { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetAlpha({this})"
		/// @CSharpLua.Set = "BlzFrameSetAlpha({this}, {0})"
		public extern int Alpha { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetValue({this})"
		/// @CSharpLua.Set = "BlzFrameSetValue({this}, {0})"
		public extern float Value { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetParent({this})"
		/// @CSharpLua.Set = "BlzFrameSetParent({this}, {0})"
		public extern framehandle Parent { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetName({this})"
		public extern string Name { get; }

		/// @CSharpLua.Get = "BlzFrameGetHeight({this})"
		/// @CSharpLua.Set = "BlzFrameSetSize({this}, BlzFrameGetWidth({this}), {0})"
		public extern float Height { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetWidth({this})"
		/// @CSharpLua.Set = "BlzFrameSetSize({this}, {0}, BlzFrameGetHeight({this}))"
		public extern float Width { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetChildrenCount({this})"
		public extern int ChildrenCount { get; }

		/// @CSharpLua.Template = "BlzFrameSetPoint({this}, {0}, {3}, {4}, {1}, {2})"
		public extern void SetPoint(framepointtype pointType, float x, float y, framehandle relative, framepointtype relativePointType);
		/// @CSharpLua.Template = "BlzFrameSetAbsPoint({this}, {0}, {1}, {2})"
		public extern void SetAbsPoint(framepointtype pointType, float x, float y);
		/// @CSharpLua.Template = "BlzFrameSetAllPoints({this}, {0})"
		public extern void SetPoints(framehandle relative);
		/// @CSharpLua.Template = "BlzFrameClearAllPoints({this})"
		public extern void ClearPoints();

		/// @CSharpLua.Template = "BlzFrameClick({this})"
		public extern void Click();
		/// @CSharpLua.Template = "BlzFrameAddText({this}, {0})"
		public extern void AddText(string text);
		/// @CSharpLua.Template = "BlzFrameSetFocus({this}, {0})"
		public extern void SetFocus(bool focus = true);
		/// @CSharpLua.Template = "BlzFrameSetModel({this}, {0}, {1})"
		public extern void SetModel(string modelFile, int cameraIndex);
		/// @CSharpLua.Template = "BlzFrameSetSpriteAnimate({this}, {0}, {1})"
		public extern void SetSpriteAnimate(int primaryProp, int flags);
		/// @CSharpLua.Template = "BlzFrameSetTexture({this}, {0}, {1}, {2})"
		public extern void SetTexture(string textureFile, int textureFillSetting, bool blend);
		/// @CSharpLua.Template = "BlzFrameSetScale({this}, {0})"
		public extern void SetScale(float scale);
		/// @CSharpLua.Template = "BlzFrameSetTooltip({this}, {0})"
		public extern void SetTooltip(framehandle tooltip);
		/// @CSharpLua.Template = "BlzFrameCageMouse({this}, {0})"
		public extern void CageMouse(bool enable);
		/// @CSharpLua.Template = "BlzFrameSetMinMaxValue({this}, {0}, {1})"
		public extern void SetMinMaxValue(float minValue, float maxValue);
		/// @CSharpLua.Template = "BlzFrameSetStepSize({this}, {0})"
		public extern void SetStepSize(float stepSize);
		/// @CSharpLua.Template = "BlzFrameSetSize({this}, {0}, {1})"
		public extern void SetSize(float width, float height);
		/// @CSharpLua.Template = "BlzFrameSetVertexColor({this}, {0})"
		public extern void SetVertexColor(int color);
		/// @CSharpLua.Template = "BlzFrameSetLevel({this}, {0})"
		public extern void SetLevel(int level);
		/// @CSharpLua.Template = "BlzFrameSetFont({this}, {0}, {1}, {2})"
		public extern void SetFont(string fileName, float height, int flags);
		/// @CSharpLua.Template = "BlzFrameSetTextAlignment({this}, {0}, {1})"
		public extern void SetTextAlignment(textaligntype verticalAlignType, textaligntype horizontalAlignType);
		/// @CSharpLua.Template = "BlzFrameGetChild({this}, {0})"
		public extern framehandle GetChild(int index);

		/// @CSharpLua.Template = "BlzDestroyFrame({this})"
		public extern void Dispose();
	}
}
