namespace WCSharp.Api.Enums
{
	/// <summary>
	/// Decides the type of chat channel prefix shown. It has no effect on the message's visibility.
	/// </summary>
	public enum ChatRecipient
	{
		/// <summary>
		/// Prefixe the message with <c>[All]</c>.
		/// </summary>
		All = 0,
		/// <summary>
		/// Prefixe the message with <c>[Allies]</c>.
		/// </summary>
		Allies = 1,
		/// <summary>
		/// Prefixe the message with <c>[Observers]</c>.
		/// </summary>
		Observers = 2,
		/// <summary>
		/// Prefixe the message with <c>[Private]</c>.
		/// </summary>
		Private = 3,
	}
}
