using WCSharp.Api;

namespace WCSharp.Dummies
{
	internal class DummyBeingRecycled
	{
		public int TicksLeft { get; set; }
		public unit Dummy { get; set; }

		public DummyBeingRecycled(unit dummy, int recycleTime)
		{
			Dummy = dummy;
			TicksLeft = recycleTime;
		}
	}
}
