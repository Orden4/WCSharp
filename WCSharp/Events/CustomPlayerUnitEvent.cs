using System;
using static War3Api.Common;

namespace WCSharp.Events
{
	internal class CustomPlayerUnitEvent
	{
		public string Identifier { get; set; }
		public playerunitevent NativeEvent { get; set; }
		public Func<int> Func { get; set; }
	}
}
