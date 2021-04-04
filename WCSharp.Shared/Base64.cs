using System;
using System.Linq;

namespace WCSharp.Shared
{
	/// <summary>
	/// Conversion courtesy of http://lua-users.org/wiki/BaseSixtyFour
	/// </summary>
	public class Base64
	{
		private const string BASE64_CHARSET = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
		private static readonly Base64 @default = new Base64();
		private static readonly object encode = Lua.Call(Lua.Load(@"
return function(data, b)
    return ((data:gsub('.', function(x) 
        local r,b='',x:byte()
        for i=8,1,-1 do r=r..(b%2^i-b%2^(i-1)>0 and '1' or '0') end
        return r;
    end)..'0000'):gsub('%d%d%d?%d?%d?%d?', function(x)
        if (#x < 6) then return '' end
        local c=0
        for i=1,6 do c=c+(x:sub(i,i)=='1' and 2^(6-i) or 0) end
        return b:sub(c+1,c+1)
    end)..({ '', '==', '=' })[#data%3+1])
end
"));
		private static readonly object decode = Lua.Call(Lua.Load(@"
return function(data, b)
    data = string.gsub(data, '[^'..b..'=]', '')
    return (data:gsub('.', function(x)
        if (x == '=') then return '' end
        local r,f='',(b:find(x)-1)
        for i=6,1,-1 do r=r..(f%2^i-f%2^(i-1)>0 and '1' or '0') end
        return r;
    end):gsub('%d%d%d?%d?%d?%d?%d?%d?', function(x)
        if (#x ~= 8) then return '' end
        local c=0
        for i=1,8 do c=c+(x:sub(i,i)=='1' and 2^(8-i) or 0) end
        return string.char(c)
    end))
end
"));

		private readonly string charset;

		/// <summary>
		/// Creates a new Base64 generator with the given character set.
		/// <para>A custom character set must be exactly 64 characters long and use the same set of characters as regular Base64. You can only change the order.</para>
		/// <para>Default: ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/</para>
		/// </summary>
		/// <param name="charset"></param>
		public Base64(string charset = BASE64_CHARSET)
		{
			if (charset == null || charset.Length != BASE64_CHARSET.Length || BASE64_CHARSET.Any(x => !charset.Contains(x)))
			{
				Console.WriteLine("Invalid base64 character set supplied. The character set must be the same length and be a scrambled version of the default Base64 character set.");
				return;
			}

			this.charset = charset;
		}

		/// <summary>
		/// Converts the given text to Base64 with the default character set.
		/// </summary>
		public static string ToBase64(string data)
		{
			return @default.Encode(data);
		}

		/// <summary>
		/// Converts the given Base64 to text with the default character set.
		/// </summary>
		public static string FromBase64(string data)
		{
			return @default.Decode(data);
		}

		/// <summary>
		/// Converts the given string into a Base64 string.
		/// </summary>
		public string Encode(string data)
		{
			return (string)Lua.Call(encode, data, this.charset);
		}

		/// <summary>
		/// Converts the given Base64 string into a regular string.
		/// </summary>
		public string Decode(string data)
		{
			return (string)Lua.Call(decode, data, this.charset);
		}
	}
}
