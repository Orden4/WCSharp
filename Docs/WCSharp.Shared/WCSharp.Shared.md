#### [WCSharp\.Shared](README.md 'README')

## WCSharp\.Shared Namespace

| Classes | |
| :--- | :--- |
| [Base64](WCSharp.Shared.Base64.md 'WCSharp\.Shared\.Base64') | Conversion courtesy of http://lua\-users\.org/wiki/BaseSixtyFour |
| [Delay](WCSharp.Shared.Delay.md 'WCSharp\.Shared\.Delay') | Basic helper class to create 0 second delays on executing actions\.   This can be used to circumvent various issues, such as unit AI locking up if you give them a new order at the same time as they start an attack. |
| [FastUtil](WCSharp.Shared.FastUtil.md 'WCSharp\.Shared\.FastUtil') |   Defines a number of miscellaneous useful methods. These methods are all inlined via the CSharpLua compiler for maximum             performance, however as a result some arguments should not be "calculated" ones (i.e., it should already be calculated when given to             this method, store it in a variable if needed) as otherwise the performance gain over the methods in [Util](WCSharp.Shared.Util.md 'WCSharp\.Shared\.Util') is             nullified.  For methods not present in this one compared to [Util](WCSharp.Shared.Util.md 'WCSharp\.Shared\.Util'), it means the [Util](WCSharp.Shared.Util.md 'WCSharp\.Shared\.Util') variant is already safely             inlined, or inlining is not possible.  For the average user, I recommend just sticking to [Util](WCSharp.Shared.Util.md 'WCSharp\.Shared\.Util') and not worrying about this variation.             The speed difference is negligble and only a concern for heavy load systems. |
| [Lua](WCSharp.Shared.Lua.md 'WCSharp\.Shared\.Lua') | Helper class for directly executing Lua without needing the \_\_CSharpLua\_\_ directive\.   This is only really useful if you cannot use __CSharpLua__, e.g. when making packages. |
| [LuaTable](WCSharp.Shared.LuaTable.md 'WCSharp\.Shared\.LuaTable') | Represents a table in Lua in a way that is easier to work with from C\#\. |
| [TypeWrapper&lt;T&gt;](WCSharp.Shared.TypeWrapper_T_.md 'WCSharp\.Shared\.TypeWrapper\<T\>') | Wrapper for WC3 handles to pass type inspection\.   Sometimes some type casts or pattern matching is required for handles, however this doesn't work as they are not proper objects.  By wrapping them in a C# object like this, we can properly cast and match handles. |
| [Util](WCSharp.Shared.Util.md 'WCSharp\.Shared\.Util') | Defines a number of miscellaneous useful methods and constants\. |
