#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared')

## TypeWrapper\<T\> Class

Wrapper for WC3 handles to pass type inspection\.

Sometimes some type casts or pattern matching is required for handles, however this doesn't work as they are not proper objects.

By wrapping them in a C# object like this, we can properly cast and match handles.

```csharp
public class TypeWrapper<T>
```
#### Type parameters

<a name='WCSharp.Shared.TypeWrapper_T_.T'></a>

`T`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; TypeWrapper\<T\>

| Constructors | |
| :--- | :--- |
| [TypeWrapper\(T\)](WCSharp.Shared.TypeWrapper_T_.TypeWrapper(T).md 'WCSharp\.Shared\.TypeWrapper\<T\>\.TypeWrapper\(T\)') | Wraps the given value in a C\# type\. |

| Properties | |
| :--- | :--- |
| [Value](WCSharp.Shared.TypeWrapper_T_.Value.md 'WCSharp\.Shared\.TypeWrapper\<T\>\.Value') | The value being wrapped\. |
