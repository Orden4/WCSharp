using System;

namespace WCSharp.ConstantGenerator
{
	internal enum Type
	{
		UNKNOWN = 0,
		ABILITY = 1,
		BUFF = 2,
		ITEM = 3,
		UNIT = 4,
		UPGRADE = 5,
		ADDITIONAL = 101
	}

	internal static class TypeMethods
	{
		public static int GetCharactersToSkip(this Type type)
		{
			return type switch
			{
				Type.ABILITY => 14,
				Type.BUFF => 18,
				Type.ITEM => 10,
				Type.UNIT => 10,
				Type.UPGRADE => 13,
				_ => throw new NotImplementedException(),
			};
		}
	}
}
