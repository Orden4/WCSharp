namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in <see cref="RegionUnitEvent"/> supported by <see cref="PlayerUnitEvents"/>.
	/// <para>All of these events fire based on a unit handle filter.</para>
	/// </summary>
	public enum RegionUnitEvent
	{
		Enters = 501,
		Leaves,
	}
}
