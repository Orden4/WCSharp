using System;

namespace WCSharp.ConstantGenerator
{
	internal class FourCC
	{
		public static int Decode(string code)
		{
			var res = 0;
			for (var i = 0; i < code.Length; i++)
			{
				var ch = code[i];
				var num = (int)ch;
				res += num * (int)Math.Pow(2, (3 - i) * 8);
			}
			return res;
		}
	}
}
