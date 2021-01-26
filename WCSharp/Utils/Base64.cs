using System;
using System.Linq;

namespace WCSharp.Utils
{
	/// <summary>
	/// Conversion courtesy of http://lua-users.org/wiki/BaseSixtyFour
	/// </summary>
	public static class Base64
	{
		private static string b = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

		/// <summary>
		/// If you really don't want people to read your Base64 strings, you can use this to change the base character set, making online converters useless.
		/// <para>A custom set must be exactly 64 characters long and use the same set of characters as regular Base64. You can only change the order.</para>
		/// <para>Default: ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/</para>
		/// <para>WARNING: Changing this will break any existing saves!</para>
		/// </summary>
		public static void SetCharset(string base64charset)
		{
			if (base64charset == null || base64charset.Length != b.Length || b.Any(x => base64charset.IndexOf(x) == -1))
			{
				Util.Debug("Invalid base64 character set supplied. The character set must be the same length and be a scrambled version of the default Base64 character set.");
				return;
			}

			b = base64charset;
		}

		/// <summary>
		/// Converts the given string into a Base64 string.
		/// </summary>
		public static string ToBase64(string data)
		{
			try
			{
#if __CSharpLua__
	/*[[
	data = ((data:gsub('.', function(x) 
		local r,b='',x:byte()
		for i=8,1,-1 do r=r..(b%2^i-b%2^(i-1)>0 and '1' or '0') end
		return r;
	end)..'0000'):gsub('%d%d%d?%d?%d?%d?', function(x)
		if (#x < 6) then return '' end
		local c=0
		for i=1,6 do c=c+(x:sub(i,i)=='1' and 2^(6-i) or 0) end
		return b:sub(c+1,c+1)
	end)..({ '', '==', '=' })[#data%3+1])
	]]*/
#endif
			}
			catch (Exception)
			{
				return "";
			}
			return data;
		}

		/// <summary>
		/// Converts the given Base64 string into a regular string.
		/// </summary>
		public static string FromBase64(string data)
		{
			try
			{
#if __CSharpLua__
	/*[[
    data = string.gsub(data, '[^'..b..'=]', '')
    data = (data:gsub('.', function(x)
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
	]]*/
#endif
			}
			catch (Exception)
			{
				return "";
			}
			return data;
		}
	}
}
