using System;
using System.Collections.Generic;

namespace WCSharp.Json
{
	public static class JsonConvert
	{
		/// <summary>
		/// Converts the given JSON string into the specified generic class.
		/// <para>Please read the documentation for details on what can and cannot be serialized.</para>
		/// </summary>
		public static T Deserialize<T>(string input)
		{
			return (T)Deserialize(input, typeof(T));
		}

		public static object Deserialize(string input, Type deserializeType)
		{
			object table = default;
#if __CSharpLua__
/*[[
--
-- json.lua
--
-- Copyright (c) 2020 rxi
--
-- Permission is hereby granted, free of charge, to any person obtaining a copy of
-- this software and associated documentation files (the "Software"), to deal in
-- the Software without restriction, including without limitation the rights to
-- use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
-- of the Software, and to permit persons to whom the Software is furnished to do
-- so, subject to the following conditions:
--
-- The above copyright notice and this permission notice shall be included in all
-- copies or substantial portions of the Software.
--
-- THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
-- IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
-- FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
-- AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
-- LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
-- OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
-- SOFTWARE.
--
local json = { _version = "0.1.2" }

-------------------------------------------------------------------------------
-- Decode
-------------------------------------------------------------------------------
local escape_char_map = {
  [ "\\" ] = "\\",
  [ "\"" ] = "\"",
  [ "\b" ] = "b",
  [ "\f" ] = "f",
  [ "\n" ] = "n",
  [ "\r" ] = "r",
  [ "\t" ] = "t",
}
local escape_char_map_inv = { [ "/" ] = "/" }
for k, v in pairs(escape_char_map) do
  escape_char_map_inv[v] = k
end
local parse
local function create_set(...)
  local res = {}
  for i = 1, select("#", ...) do
    res[ select(i, ...) ] = true
  end
  return res
end
local space_chars   = create_set(" ", "\t", "\r", "\n")
local delim_chars   = create_set(" ", "\t", "\r", "\n", "]", "}", ",")
local escape_chars  = create_set("\\", "/", '"', "b", "f", "n", "r", "t", "u")
local literals      = create_set("true", "false", "null")
local literal_map = {
  [ "true"  ] = true,
  [ "false" ] = false,
  [ "null"  ] = nil,
}
local function next_char(str, idx, set, negate)
  for i = idx, #str do
    if set[str:sub(i, i)] ~= negate then
      return i
    end
  end
  return #str + 1
end
local function decode_error(str, idx, msg)
  local line_count = 1
  local col_count = 1
  for i = 1, idx - 1 do
    col_count = col_count + 1
    if str:sub(i, i) == "\n" then
      line_count = line_count + 1
      col_count = 1
    end
  end
  error( string.format("%s at line %d col %d", msg, line_count, col_count) )
end
local function codepoint_to_utf8(n)
  -- http://scripts.sil.org/cms/scripts/page.php?site_id=nrsi&id=iws-appendixa
  local f = math.floor
  if n <= 0x7f then
    return string.char(n)
  elseif n <= 0x7ff then
    return string.char(f(n / 64) + 192, n % 64 + 128)
  elseif n <= 0xffff then
    return string.char(f(n / 4096) + 224, f(n % 4096 / 64) + 128, n % 64 + 128)
  elseif n <= 0x10ffff then
    return string.char(f(n / 262144) + 240, f(n % 262144 / 4096) + 128,
                       f(n % 4096 / 64) + 128, n % 64 + 128)
  end
  error( string.format("invalid unicode codepoint '%x'", n) )
end
local function parse_unicode_escape(s)
  local n1 = tonumber( s:sub(1, 4),  16 )
  local n2 = tonumber( s:sub(7, 10), 16 )
   -- Surrogate pair?
  if n2 then
    return codepoint_to_utf8((n1 - 0xd800) * 0x400 + (n2 - 0xdc00) + 0x10000)
  else
    return codepoint_to_utf8(n1)
  end
end
local function parse_string(str, i)
  local res = ""
  local j = i + 1
  local k = j
  while j <= #str do
    local x = str:byte(j)
    if x < 32 then
      decode_error(str, j, "control character in string")
    elseif x == 92 then -- `\`: Escape
      res = res .. str:sub(k, j - 1)
      j = j + 1
      local c = str:sub(j, j)
      if c == "u" then
        local hex = str:match("^[dD][89aAbB]%x%x\\u%x%x%x%x", j + 1)
                 or str:match("^%x%x%x%x", j + 1)
                 or decode_error(str, j - 1, "invalid unicode escape in string")
        res = res .. parse_unicode_escape(hex)
        j = j + #hex
      else
        if not escape_chars[c] then
          decode_error(str, j - 1, "invalid escape char '" .. c .. "' in string")
        end
        res = res .. escape_char_map_inv[c]
      end
      k = j + 1
    elseif x == 34 then -- `"`: End of string
      res = res .. str:sub(k, j - 1)
      return res, j + 1
    end
    j = j + 1
  end
  decode_error(str, i, "expected closing quote for string")
end
local function parse_number(str, i)
  local x = next_char(str, i, delim_chars)
  local s = str:sub(i, x - 1)
  local n = tonumber(s)
  if not n then
    decode_error(str, i, "invalid number '" .. s .. "'")
  end
  return n, x
end
local function parse_literal(str, i)
  local x = next_char(str, i, delim_chars)
  local word = str:sub(i, x - 1)
  if not literals[word] then
    decode_error(str, i, "invalid literal '" .. word .. "'")
  end
  return literal_map[word], x
end
local function parse_array(str, i)
  local res = {}
  local n = 1
  i = i + 1
  while 1 do
    local x
    i = next_char(str, i, space_chars, true)
    -- Empty / end of array?
    if str:sub(i, i) == "]" then
      i = i + 1
      break
    end
    -- Read token
    x, i = parse(str, i)
    res[n] = x
    n = n + 1
    -- Next token
    i = next_char(str, i, space_chars, true)
    local chr = str:sub(i, i)
    i = i + 1
    if chr == "]" then break end
    if chr ~= "," then decode_error(str, i, "expected ']' or ','") end
  end
  return res, i
end
local function parse_object(str, i)
  local res = {}
  i = i + 1
  while 1 do
    local key, val
    i = next_char(str, i, space_chars, true)
    -- Empty / end of object?
    if str:sub(i, i) == "}" then
      i = i + 1
      break
    end
    -- Read key
    if str:sub(i, i) ~= '"' then
      decode_error(str, i, "expected string for key")
    end
    key, i = parse(str, i)
    -- Read ':' delimiter
    i = next_char(str, i, space_chars, true)
    if str:sub(i, i) ~= ":" then
      decode_error(str, i, "expected ':' after key")
    end
    i = next_char(str, i + 1, space_chars, true)
    -- Read value
    val, i = parse(str, i)
    -- Set
    res[key] = val
    -- Next token
    i = next_char(str, i, space_chars, true)
    local chr = str:sub(i, i)
    i = i + 1
    if chr == "}" then break end
    if chr ~= "," then decode_error(str, i, "expected '}' or ','") end
  end
  return res, i
end
local char_func_map = {
  [ '"' ] = parse_string,
  [ "0" ] = parse_number,
  [ "1" ] = parse_number,
  [ "2" ] = parse_number,
  [ "3" ] = parse_number,
  [ "4" ] = parse_number,
  [ "5" ] = parse_number,
  [ "6" ] = parse_number,
  [ "7" ] = parse_number,
  [ "8" ] = parse_number,
  [ "9" ] = parse_number,
  [ "-" ] = parse_number,
  [ "t" ] = parse_literal,
  [ "f" ] = parse_literal,
  [ "n" ] = parse_literal,
  [ "[" ] = parse_array,
  [ "{" ] = parse_object,
}
parse = function(str, idx)
  local chr = str:sub(idx, idx)
  local f = char_func_map[chr]
  if f then
    return f(str, idx)
  end
  decode_error(str, idx, "unexpected character '" .. chr .. "'")
end
function json.decode(str)
  if type(str) ~= "string" then
    error("expected argument of type string, got " .. type(str))
  end
  local res, idx = parse(str, next_char(str, 1, space_chars, true))
  idx = next_char(str, idx, space_chars, true)
  if idx <= #str then
    decode_error(str, idx, "trailing garbage")
  end
  return res
end
table = json.decode(input)
]]*/
#endif
			return DeserializeLuaTable(table, deserializeType);
		}

		public static string Serialize<T>(T input)
		{
			string value = default;
#if __CSharpLua__
/*[[
--
-- json.lua
--
-- Copyright (c) 2020 rxi
--
-- Permission is hereby granted, free of charge, to any person obtaining a copy of
-- this software and associated documentation files (the "Software"), to deal in
-- the Software without restriction, including without limitation the rights to
-- use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
-- of the Software, and to permit persons to whom the Software is furnished to do
-- so, subject to the following conditions:
--
-- The above copyright notice and this permission notice shall be included in all
-- copies or substantial portions of the Software.
--
-- THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
-- IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
-- FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
-- AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
-- LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
-- OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
-- SOFTWARE.
--
local json = { _version = "0.1.2" }
-------------------------------------------------------------------------------
-- Encode
-------------------------------------------------------------------------------
local encode
local escape_char_map = {
  [ "\\" ] = "\\",
  [ "\"" ] = "\"",
  [ "\b" ] = "b",
  [ "\f" ] = "f",
  [ "\n" ] = "n",
  [ "\r" ] = "r",
  [ "\t" ] = "t",
}
local escape_char_map_inv = { [ "/" ] = "/" }
for k, v in pairs(escape_char_map) do
  escape_char_map_inv[v] = k
end
local function escape_char(c)
  return "\\" .. (escape_char_map[c] or string.format("u%04x", c:byte()))
end
local function encode_nil(val)
  return "null"
end
local function encode_table(val, stack)
  local res = {}
  stack = stack or {}
  -- Circular reference?
  if stack[val] then error("circular reference") end
  stack[val] = true
  if rawget(val, 1) ~= nil or next(val) == nil then
    -- Treat as array -- check keys are valid and it is not sparse
    local n = 0
    for k in pairs(val) do
      if type(k) ~= "number" then
        error("invalid table: mixed or invalid key types")
      end
      n = n + 1
    end
    if n ~= #val then
      error("invalid table: sparse array")
    end
    -- Encode
    for i, v in ipairs(val) do
      table.insert(res, encode(v, stack))
    end
    stack[val] = nil
    return "[" .. table.concat(res, ",") .. "]"
  else
    -- Treat as an object
    for k, v in pairs(val) do
	  local kType = type(k)
	  if kType == "number" then
        k = tostring(k)
	  elseif kType ~= "string" then
        error("invalid table: mixed or invalid key types")
      end
      table.insert(res, encode(k, stack) .. ":" .. encode(v, stack))
    end
    stack[val] = nil
    return "{" .. table.concat(res, ",") .. "}"
  end
end
local function encode_string(val)
  return '"' .. val:gsub('[%z\1-\31\\"]', escape_char) .. '"'
end
local function encode_number(val)
  -- Check for NaN, -inf and inf
  if val ~= val or val <= -math.huge or val >= math.huge then
    error("unexpected number value '" .. tostring(val) .. "'")
  end
  return string.format("%.14g", val)
end
local type_func_map = {
  [ "nil"     ] = encode_nil,
  [ "table"   ] = encode_table,
  [ "string"  ] = encode_string,
  [ "number"  ] = encode_number,
  [ "boolean" ] = tostring,
}
encode = function(val, stack)
  local t = type(val)
  local f = type_func_map[t]
  if f then
    return f(val, stack)
  end
  error("unexpected type '" .. t .. "'")
end
function json.encode(val)
  return ( encode(val) )
end
value = json.encode(input)
]]*/
#endif
			return value;
		}

		private static object DeserializeLuaTable(object table, Type type)
		{
			var instance = Activator.CreateInstance(type);

			if (type.IsGenericType)
			{
				if (type.GetGenericTypeDefinition() == typeof(List<>))
				{
					return DeserializeList(type, instance, table);
				}
				else if (type.GetGenericTypeDefinition() == typeof(Dictionary<,>))
				{
					return DeserializeDictionary(type, instance, table);
				}
			}

			object value = default;

			foreach (var property in type.GetProperties())
			{
				var name = property.Name;
#if __CSharpLua__
/*[[
value = table[name];
]]*/
#endif
				value = DeserializeLuaValue(value, property.PropertyType);
				if (value != null)
				{
					property.SetValue(instance, value);
				}
			}

			return instance;
		}

		private static object DeserializeList(Type type, object instance, object table)
		{
			var genericType = type.GetGenericArguments()[0];
			var add = type.GetMethod("Add", new Type[] { genericType });

			object v = default;
#if __CSharpLua__
/*[[
for k,v in pairs(table) do
]]*/
#endif
			add.Invoke(instance, new object[] { DeserializeLuaValue(v, genericType) });
#if __CSharpLua__
/*[[
end
]]*/
#endif
			return instance;
		}

		private static object DeserializeDictionary(Type type, object instance, object table)
		{
			var genericTypes = type.GetGenericArguments();
			var add = type.GetMethod("Add", genericTypes);

			object k = default;
			object v = default;
#if __CSharpLua__
/*[[
for k,v in pairs(table) do
]]*/
#endif
			k = DeserializeLuaString(k, genericTypes[0]);
			v = DeserializeLuaValue(v, genericTypes[1]);
			add.Invoke(instance, new object[] { k, v });
#if __CSharpLua__
/*[[
end
]]*/
#endif
			return instance;
		}

		private static object DeserializeLuaString(object stringObject, Type type)
		{
			if (stringObject is string @string)
			{
				if (type == typeof(bool))
				{
					if (bool.TryParse(@string, out var @bool))
					{
						return @bool;
					}
				}
				else if (type == typeof(byte))
				{
					if (byte.TryParse(@string, out var @byte))
					{
						return @byte;
					}
				}
				else if (type == typeof(sbyte))
				{
					if (sbyte.TryParse(@string, out var @sbyte))
					{
						return @sbyte;
					}
				}
				else if (type == typeof(char))
				{
					if (char.TryParse(@string, out var @char))
					{
						return @char;
					}
				}
				else if (type == typeof(decimal))
				{
					if (decimal.TryParse(@string, out var @decimal))
					{
						return @decimal;
					}
				}
				else if (type == typeof(double))
				{
					if (double.TryParse(@string, out var @double))
					{
						return @double;
					}
				}
				else if (type == typeof(float))
				{
					if (float.TryParse(@string, out var @float))
					{
						return @float;
					}
				}
				else if (type == typeof(int))
				{
					if (int.TryParse(@string, out var @int))
					{
						return @int;
					}
				}
				else if (type == typeof(uint))
				{
					if (uint.TryParse(@string, out var @uint))
					{
						return @uint;
					}
				}
				else if (type == typeof(long))
				{
					if (long.TryParse(@string, out var @long))
					{
						return @long;
					}
				}
				else if (type == typeof(ulong))
				{
					if (ulong.TryParse(@string, out var @ulong))
					{
						return @ulong;
					}
				}
				else if (type == typeof(short))
				{
					if (short.TryParse(@string, out var @short))
					{
						return @short;
					}
				}
				else if (type == typeof(ushort))
				{
					if (ushort.TryParse(@string, out var @ushort))
					{
						return @ushort;
					}
				}
				else if (type == typeof(string))
				{
					return @string;
				}
				else
				{
					throw new Exception("Cannot deserialize dictionaries with non-primitive key types.");
				}
			}

			throw new Exception("Serialized dictionary keys should always be strings.");
		}

		private static object DeserializeLuaValue(object value, Type type)
		{
			if (!type.IsClass || type == typeof(string))
			{
				return value;
			}
			else
			{
				return DeserializeLuaTable(value, type);
			}

			//if (type == typeof(bool))
			//{
			//	if (value is bool @bool)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(byte))
			//{
			//	if (value is byte @byte)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(sbyte))
			//{
			//	if (value is sbyte @sbyte)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(char))
			//{
			//	if (value is char @char)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(decimal))
			//{
			//	if (value is decimal @decimal)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(double))
			//{
			//	if (value is double @double)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(float))
			//{
			//	if (value is float @float)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(int))
			//{
			//	if (value is int @int)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(uint))
			//{
			//	if (value is uint @uint)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(long))
			//{
			//	if (value is long @long)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(ulong))
			//{
			//	if (value is ulong @ulong)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(short))
			//{
			//	if (value is short @short)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(ushort))
			//{
			//	if (value is ushort @ushort)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(string))
			//{
			//	if (value is string @string)
			//	{
			//		return value;
			//	}
			//}
			//else if (type.IsClass)
			//{
			//	return DeserializeLuaTable(value, type);
			//}

			//return null;
		}
	}
}
