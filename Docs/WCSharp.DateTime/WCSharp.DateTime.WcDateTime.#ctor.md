#### [WCSharp\.DateTime](README.md 'README')
### [WCSharp\.DateTime](WCSharp.DateTime.md 'WCSharp\.DateTime').[WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime')

## WcDateTime Constructors

| Overloads | |
| :--- | :--- |
| [WcDateTime\(int\)](WCSharp.DateTime.WcDateTime.#ctor.md#WCSharp.DateTime.WcDateTime.WcDateTime(int) 'WCSharp\.DateTime\.WcDateTime\.WcDateTime\(int\)') | Creates a new [WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime') with the given number of seconds since January 1st, 1970, 00:00:00\. |
| [WcDateTime\(int, int, int\)](WCSharp.DateTime.WcDateTime.#ctor.md#WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int) 'WCSharp\.DateTime\.WcDateTime\.WcDateTime\(int, int, int\)') | Creates a new [WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime') with the given year, month and day\.   The given date must be between January 1st, 1970, 00:00:00 and January 19, 2038, 03:14:07. |
| [WcDateTime\(int, int, int, int, int, int\)](WCSharp.DateTime.WcDateTime.#ctor.md#WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int,int,int,int) 'WCSharp\.DateTime\.WcDateTime\.WcDateTime\(int, int, int, int, int, int\)') | |

<a name='ctor.md#WCSharp.DateTime.WcDateTime.WcDateTime(int)'></a>

## WcDateTime\(int\) Constructor

Creates a new [WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime') with the given number of seconds since January 1st, 1970, 00:00:00\.

```csharp
public WcDateTime(int seconds);
```
#### Parameters

<a name='WCSharp.DateTime.WcDateTime.WcDateTime(int).seconds'></a>

`seconds` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='ctor.md#WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int)'></a>

## WcDateTime\(int, int, int\) Constructor

Creates a new [WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime') with the given year, month and day\.

The given date must be between January 1st, 1970, 00:00:00 and January 19, 2038, 03:14:07.

```csharp
public WcDateTime(int year, int month, int day);
```
#### Parameters

<a name='WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int).year'></a>

`year` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The year\. Must be between 1970 and 2038\.

<a name='WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int).month'></a>

`month` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The month of the year\. Must be between 1 and 12\.

<a name='WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int).day'></a>

`day` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The day of the month\.

<a name='ctor.md#WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int,int,int,int)'></a>

## WcDateTime\(int, int, int, int, int, int\) Constructor

```csharp
public WcDateTime(int year, int month, int day, int hour, int minute, int second);
```
#### Parameters

<a name='WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int,int,int,int).year'></a>

`year` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The year\. Must be between 1970 and 2038\.

<a name='WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int,int,int,int).month'></a>

`month` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The month of the year\. Must be between 1 and 12\.

<a name='WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int,int,int,int).day'></a>

`day` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The day of the month\.

<a name='WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int,int,int,int).hour'></a>

`hour` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The hour of the day\. Must be between 0 and 23\.

<a name='WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int,int,int,int).minute'></a>

`minute` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The minute of the hour\. Must be between 0 and 59\.

<a name='WCSharp.DateTime.WcDateTime.WcDateTime(int,int,int,int,int,int).second'></a>

`second` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The second of the minute\. Must be between 0 and 59\.