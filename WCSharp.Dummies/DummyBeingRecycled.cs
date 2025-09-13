using WCSharp.Api;

namespace WCSharp.Dummies
{
	internal class DummyBeingRecycled
	{
		public float TimeLeft { get; set; }
		public unit Dummy { get; set; }

		public DummyBeingRecycled(unit dummy, float recycleTime)
		{
			Dummy = dummy;
			TimeLeft = recycleTime;
		}
	}
}
