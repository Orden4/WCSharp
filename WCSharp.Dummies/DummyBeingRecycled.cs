using static War3Api.Common;

namespace WCSharp.Dummies
{
	internal class DummyBeingRecycled
	{
		public float TicksLeft { get; set; }
		public unit Dummy { get; set; }

		public DummyBeingRecycled(unit dummy, float recycleTime)
		{
			Dummy = dummy;
			TicksLeft = recycleTime;
		}
	}
}
