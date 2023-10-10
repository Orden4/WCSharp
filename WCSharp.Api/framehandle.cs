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

		/// @CSharpLua.Get = "BlzFrameIsVisible({0})"
		/// @CSharpLua.Set = "BlzFrameSetVisible({0}, {1})"
		public extern bool Visibile { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetText({0})"
		/// @CSharpLua.Set = "BlzFrameSetText({0}, {1})"
		public extern string Text { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetTextSizeLimit({0})"
		/// @CSharpLua.Set = "BlzFrameSetTextSizeLimit({0}, {1})"
		public extern int TextSizeLimit { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetEnable({0})"
		/// @CSharpLua.Set = "BlzFrameSetEnable({0}, {1})"
		public extern bool Enabled { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetAlpha({0})"
		/// @CSharpLua.Set = "BlzFrameSetAlpha({0}, {1})"
		public extern int Alpha { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetValue({0})"
		/// @CSharpLua.Set = "BlzFrameSetValue({0}, {1})"
		public extern float Value { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetParent({0})"
		/// @CSharpLua.Set = "BlzFrameSetParent({0}, {1})"
		public extern framehandle Parent { get; set; }

		/// @CSharpLua.Get = "BlzFrameGetName({0})"
		public extern string Name { get; }

		/// @CSharpLua.Get = "BlzFrameGetHeight({0})"
		public extern float Height { get; }

		/// @CSharpLua.Get = "BlzFrameGetWidth({0})"
		public extern float Width { get; }

		/// @CSharpLua.Get = "BlzFrameGetChildrenCount({0})"
		public extern int ChildrenCount { get; }

		/// @CSharpLua.Template = "BlzFrameSetPoint({0}, {1}, {4}, {5}, {2}, {3})"
		public extern void SetPoint(framepointtype pointType, float x, float y, framehandle relative, framepointtype relativePointType);
		/// @CSharpLua.Template = "BlzFrameSetAbsPoint({0}, {1}, {2}, {3})"
		public extern void SetAbsPoint(framepointtype pointType, float x, float y);
		/// @CSharpLua.Template = "BlzFrameSetAllPoints({0}, {1})"
		public extern void SetPoints(framehandle relative);
		/// @CSharpLua.Template = "BlzFrameClearAllPoints({0})"
		public extern void ClearPoints();

		/// @CSharpLua.Template = "BlzFrameClick({0})"
		public extern void Click();
		/// @CSharpLua.Template = "BlzFrameAddText({0}, {1})"
		public extern void AddText(string text);
		/// @CSharpLua.Template = "BlzFrameSetFocus({0}, {1})"
		public extern void SetFocus(bool focus = true);
		/// @CSharpLua.Template = "BlzFrameSetModel({0}, {1}, {2})"
		public extern void SetModel(string modelFile, int cameraIndex);
		/// @CSharpLua.Template = "BlzFrameSetSpriteAnimate({0}, {1}, {2})"
		public extern void SetSpriteAnimate(int primaryProp, int flags);
		/// @CSharpLua.Template = "BlzFrameSetTexture({0}, {1}, {2})"
		public extern void SetTexture(string textureFile, int textureFillSetting, bool blend);
		/// @CSharpLua.Template = "BlzFrameSetScale({0}, {1})"
		public extern void SetScale(float scale);
		/// @CSharpLua.Template = "BlzFrameSetTooltip({0}, {1})"
		public extern void SetTooltip(framehandle tooltip);
		/// @CSharpLua.Template = "BlzFrameCageMouse({0}, {1})"
		public extern void CageMouse(bool enable);
		/// @CSharpLua.Template = "BlzFrameSetMinMaxValue({0}, {1}, {2})"
		public extern void SetMinMaxValue(float minValue, float maxValue);
		/// @CSharpLua.Template = "BlzFrameSetStepSize({0}, {1})"
		public extern void SetStepSize(float stepSize);
		/// @CSharpLua.Template = "BlzFrameSetSize({0}, {1}, {2})"
		public extern void SetSize(float width, float height);
		/// @CSharpLua.Template = "BlzFrameSetVertexColor({0}, {1})"
		public extern void SetVertexColor(int color);
		/// @CSharpLua.Template = "BlzFrameSetLevel({0}, {1})"
		public extern void SetLevel(int level);
		/// @CSharpLua.Template = "BlzFrameSetFont({0}, {1}, {2}, {3})"
		public extern void SetFont(string fileName, float height, int flags);
		/// @CSharpLua.Template = "BlzFrameSetTextAlignment({0}, {1}, {2})"
		public extern void SetTextAlignment(textaligntype verticalAlignType, textaligntype horizontalAlignType);
		/// @CSharpLua.Template = "BlzFrameGetChild({0}, {1})"
		public extern framehandle GetChild(int index);

		/// @CSharpLua.Template = "BlzDestroyFrame({0})"
		public extern void Dispose();
	}
}
