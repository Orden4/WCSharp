### [WCSharp.DateTime](WCSharp.DateTime.md 'WCSharp.DateTime')

## WcTimeSpan Class

Represents a duration of time, with a precision in seconds.

```csharp
public class WcTimeSpan :
System.IComparable,
System.IComparable<WCSharp.DateTime.WcTimeSpan>,
System.IEquatable<WCSharp.DateTime.WcTimeSpan>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; WcTimeSpan

Implements [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [WcTimeSpan(int)](WCSharp.DateTime.WcTimeSpan.WcTimeSpan(int).md 'WCSharp.DateTime.WcTimeSpan.WcTimeSpan(int)') | Creates a new [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') instance with a duration of the given number of seconds. |
| [WcTimeSpan(int, int, int)](WCSharp.DateTime.WcTimeSpan.WcTimeSpan(int,int,int).md 'WCSharp.DateTime.WcTimeSpan.WcTimeSpan(int, int, int)') | Creates a new [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') instance with a duration of the given number of hours, minutes and seconds. |
| [WcTimeSpan(int, int, int, int)](WCSharp.DateTime.WcTimeSpan.WcTimeSpan(int,int,int,int).md 'WCSharp.DateTime.WcTimeSpan.WcTimeSpan(int, int, int, int)') | Creates a new [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') instance with a duration of the given number of days, hours, minutes and seconds. |

| Fields | |
| :--- | :--- |
| [SECONDS_PER_DAY](WCSharp.DateTime.WcTimeSpan.SECONDS_PER_DAY.md 'WCSharp.DateTime.WcTimeSpan.SECONDS_PER_DAY') | The number of seconds in a day. |
| [SECONDS_PER_HOUR](WCSharp.DateTime.WcTimeSpan.SECONDS_PER_HOUR.md 'WCSharp.DateTime.WcTimeSpan.SECONDS_PER_HOUR') | The number of seconds in an hour. |
| [SECONDS_PER_MINUTE](WCSharp.DateTime.WcTimeSpan.SECONDS_PER_MINUTE.md 'WCSharp.DateTime.WcTimeSpan.SECONDS_PER_MINUTE') | The number of seconds in a minute. |

| Properties | |
| :--- | :--- |
| [Days](WCSharp.DateTime.WcTimeSpan.Days.md 'WCSharp.DateTime.WcTimeSpan.Days') | The number of whole days in this [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') (as a timestamp). |
| [Hours](WCSharp.DateTime.WcTimeSpan.Hours.md 'WCSharp.DateTime.WcTimeSpan.Hours') | The number of whole hours in this [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') (as a timestamp). |
| [LocalPlaytime](WCSharp.DateTime.WcTimeSpan.LocalPlaytime.md 'WCSharp.DateTime.WcTimeSpan.LocalPlaytime') | Returns the time that Warcraft III has been running for the current player.<br/><br/><br/>WARNING: Be careful when using this! You may trigger a desync! |
| [MaxValue](WCSharp.DateTime.WcTimeSpan.MaxValue.md 'WCSharp.DateTime.WcTimeSpan.MaxValue') | A timespan with a duration of [System.Int32.MaxValue](https://docs.microsoft.com/en-us/dotnet/api/System.Int32.MaxValue 'System.Int32.MaxValue') (in seconds). |
| [Minutes](WCSharp.DateTime.WcTimeSpan.Minutes.md 'WCSharp.DateTime.WcTimeSpan.Minutes') | The number of whole minutes in this [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') (as a timestamp). |
| [MinValue](WCSharp.DateTime.WcTimeSpan.MinValue.md 'WCSharp.DateTime.WcTimeSpan.MinValue') | A timespan with a duration of [System.Int32.MinValue](https://docs.microsoft.com/en-us/dotnet/api/System.Int32.MinValue 'System.Int32.MinValue') (in seconds). |
| [Seconds](WCSharp.DateTime.WcTimeSpan.Seconds.md 'WCSharp.DateTime.WcTimeSpan.Seconds') | The number of whole seconds in this [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') (as a timestamp). |
| [TotalDays](WCSharp.DateTime.WcTimeSpan.TotalDays.md 'WCSharp.DateTime.WcTimeSpan.TotalDays') | The total length of this [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') represented in days. |
| [TotalHours](WCSharp.DateTime.WcTimeSpan.TotalHours.md 'WCSharp.DateTime.WcTimeSpan.TotalHours') | The total length of this [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') represented in hours. |
| [TotalMinutes](WCSharp.DateTime.WcTimeSpan.TotalMinutes.md 'WCSharp.DateTime.WcTimeSpan.TotalMinutes') | The total length of this [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') represented in minutes. |
| [TotalSeconds](WCSharp.DateTime.WcTimeSpan.TotalSeconds.md 'WCSharp.DateTime.WcTimeSpan.TotalSeconds') | The total length of this [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') represented in seconds. |
| [Zero](WCSharp.DateTime.WcTimeSpan.Zero.md 'WCSharp.DateTime.WcTimeSpan.Zero') | A timespan with a duration of 0. |

| Methods | |
| :--- | :--- |
| [Add(WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.Add(WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.Add(WCSharp.DateTime.WcTimeSpan)') | Returns a new [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') whose value is the sum of this instance and the given object. |
| [CompareTo(object)](WCSharp.DateTime.WcTimeSpan.CompareTo(object).md 'WCSharp.DateTime.WcTimeSpan.CompareTo(object)') | Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object. |
| [Deserialize(string)](WCSharp.DateTime.WcTimeSpan.Deserialize(string).md 'WCSharp.DateTime.WcTimeSpan.Deserialize(string)') | Attempts to parse the given string as the number of seconds. |
| [Duration()](WCSharp.DateTime.WcTimeSpan.Duration().md 'WCSharp.DateTime.WcTimeSpan.Duration()') | Returns a new [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') whose value is the absolute value of this instance. |
| [Equals(object)](WCSharp.DateTime.WcTimeSpan.Equals(object).md 'WCSharp.DateTime.WcTimeSpan.Equals(object)') | Determines whether the specified object is equal to the current object. |
| [GetHashCode()](WCSharp.DateTime.WcTimeSpan.GetHashCode().md 'WCSharp.DateTime.WcTimeSpan.GetHashCode()') | Serves as the default hash function. |
| [Negate()](WCSharp.DateTime.WcTimeSpan.Negate().md 'WCSharp.DateTime.WcTimeSpan.Negate()') | Returns a new [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') whose value is the negated value of this instance. |
| [Serialize(WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.Serialize(WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.Serialize(WCSharp.DateTime.WcTimeSpan)') | Returns a string representing the number of seconds contained in [wcTimeSpan](WCSharp.DateTime.WcTimeSpan.Serialize(WCSharp.DateTime.WcTimeSpan).md#WCSharp.DateTime.WcTimeSpan.Serialize(WCSharp.DateTime.WcTimeSpan).wcTimeSpan 'WCSharp.DateTime.WcTimeSpan.Serialize(WCSharp.DateTime.WcTimeSpan).wcTimeSpan'). |
| [Subtract(WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.Subtract(WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.Subtract(WCSharp.DateTime.WcTimeSpan)') | Returns a new [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') whose value is the difference of this instance and the given object. |
| [ToString()](WCSharp.DateTime.WcTimeSpan.ToString().md 'WCSharp.DateTime.WcTimeSpan.ToString()') | Outputs this [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') in the standard format of "d:hh:mm:ss" or "hh:mm:ss" if less than 1 day. |
| [ToString(string)](WCSharp.DateTime.WcTimeSpan.ToString(string).md 'WCSharp.DateTime.WcTimeSpan.ToString(string)') | Returns a string representation using the given format.<br/><br/><br/>See the wiki for more information on the format specification. |

| Operators | |
| :--- | :--- |
| [operator +(WcTimeSpan, WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.op_Addition(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.op_Addition(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan)') | Returns a new [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') that is equal to [a](WCSharp.DateTime.WcTimeSpan.op_Addition(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md#WCSharp.DateTime.WcTimeSpan.op_Addition(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).a 'WCSharp.DateTime.WcTimeSpan.op_Addition(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan).a') plus [b](WCSharp.DateTime.WcTimeSpan.op_Addition(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md#WCSharp.DateTime.WcTimeSpan.op_Addition(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).b 'WCSharp.DateTime.WcTimeSpan.op_Addition(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan).b'). |
| [operator ==(WcTimeSpan, WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.op_Equality(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.op_Equality(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan)') | Returns true if [a](WCSharp.DateTime.WcTimeSpan.op_Equality(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md#WCSharp.DateTime.WcTimeSpan.op_Equality(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).a 'WCSharp.DateTime.WcTimeSpan.op_Equality(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan).a') represents an equally long time as [b](WCSharp.DateTime.WcTimeSpan.op_Equality(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md#WCSharp.DateTime.WcTimeSpan.op_Equality(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).b 'WCSharp.DateTime.WcTimeSpan.op_Equality(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan).b'). |
| [operator &gt;(WcTimeSpan, WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.op_GreaterThan(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.op_GreaterThan(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan)') | |
| [operator &gt;=(WcTimeSpan, WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.op_GreaterThanOrEqual(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.op_GreaterThanOrEqual(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan)') | |
| [operator !=(WcTimeSpan, WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.op_Inequality(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.op_Inequality(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan)') | |
| [operator &lt;(WcTimeSpan, WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.op_LessThan(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.op_LessThan(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan)') | |
| [operator &lt;=(WcTimeSpan, WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.op_LessThanOrEqual(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.op_LessThanOrEqual(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan)') | |
| [operator -(WcTimeSpan, WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.op_Subtraction(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.op_Subtraction(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan)') | Returns a new [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') that is equal to [a](WCSharp.DateTime.WcTimeSpan.op_Subtraction(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md#WCSharp.DateTime.WcTimeSpan.op_Subtraction(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).a 'WCSharp.DateTime.WcTimeSpan.op_Subtraction(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan).a') minus [b](WCSharp.DateTime.WcTimeSpan.op_Subtraction(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).md#WCSharp.DateTime.WcTimeSpan.op_Subtraction(WCSharp.DateTime.WcTimeSpan,WCSharp.DateTime.WcTimeSpan).b 'WCSharp.DateTime.WcTimeSpan.op_Subtraction(WCSharp.DateTime.WcTimeSpan, WCSharp.DateTime.WcTimeSpan).b'). |
| [operator -(WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.op_UnaryNegation(WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.op_UnaryNegation(WCSharp.DateTime.WcTimeSpan)') | Returns a new [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan') that is the negation of the time represented by [a](WCSharp.DateTime.WcTimeSpan.op_UnaryNegation(WCSharp.DateTime.WcTimeSpan).md#WCSharp.DateTime.WcTimeSpan.op_UnaryNegation(WCSharp.DateTime.WcTimeSpan).a 'WCSharp.DateTime.WcTimeSpan.op_UnaryNegation(WCSharp.DateTime.WcTimeSpan).a'). |
| [operator +(WcTimeSpan)](WCSharp.DateTime.WcTimeSpan.op_UnaryPlus(WCSharp.DateTime.WcTimeSpan).md 'WCSharp.DateTime.WcTimeSpan.op_UnaryPlus(WCSharp.DateTime.WcTimeSpan)') | Since no changes are required, simply returns the given [WcTimeSpan](WCSharp.DateTime.WcTimeSpan.md 'WCSharp.DateTime.WcTimeSpan'). |
