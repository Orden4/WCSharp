namespace WCSharp.JassDoc.Bridge
{
	public enum CSharpLuaAnnotationKind
	{
		Unknown,
		Template,
		Get,
		Set,
		Ignore,
		NoField,
		Params,
	}

	public static class CSharpLuaAnnotationKindExtensions
	{
		public static bool HasValue(this CSharpLuaAnnotationKind kind)
		{
			return kind == CSharpLuaAnnotationKind.Template
				|| kind == CSharpLuaAnnotationKind.Get
				|| kind == CSharpLuaAnnotationKind.Set;
		}
	}
}
