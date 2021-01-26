using System;

namespace WCSharp.Events
{
	public interface IPeriodicAction : IDisposable
	{
		bool Active { get; set; }
		void Action();
	}
}
