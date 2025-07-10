namespace WCSharp.Api.Enums
{
	/// <summary>
	/// Decides the type of chat channel prefix shown. It has no effect on the message's visibility.
	/// </summary>
	public enum ChatRecipient
	{
		All = 0,
		Allies = 1,
		Observers = 2,
		Private = 3,
	}
}
