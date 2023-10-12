using WCSharp.Json;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.SaveLoad
{
	/// <summary>
	/// Abstract class containing the definitions that the SaveSystem needs in order to save and load your custom save data.
	/// </summary>
	public abstract class Saveable
	{
		internal player player;
		internal int saveSlot;

		/// <summary>
		/// Returns the player object that this save is bound to.
		/// </summary>
		public player GetPlayer()
		{
			return this.player;
		}

		/// <summary>
		/// Returns the save slot that this save is bound to.
		/// </summary>
		public int GetSaveSlot()
		{
			return this.saveSlot;
		}

		/// <summary>
		/// Sets the player that this save is bound to.
		/// </summary>
		/// <param name="player"></param>
		public void SetPlayer(player player)
		{
			this.player = player;
		}

		/// <summary>
		/// Sets the save slot that this save is bound to.
		/// </summary>
		/// <param name="saveSlot"></param>
		public void SetSaveSlot(int saveSlot)
		{
			this.saveSlot = saveSlot;
		}
	}

	/// <summary>
	/// Provides some type-explicit extension methods for <see cref="Saveable"/>s.
	/// </summary>
	public static class SaveableExtensions
	{
		/// <summary>
		/// Creates a clone of the given save by converting it to JSON and back, and re-sets the player and save slot.
		/// <para>Useful for if you want to create a clone to compare save data before and after a game.</para>
		/// </summary>
		public static T Clone<T>(this T saveable) where T : Saveable
		{
			var clone = JsonConvert.Deserialize<T>(JsonConvert.Serialize(saveable));
			clone.SetPlayer(saveable.GetPlayer());
			clone.SetSaveSlot(saveable.GetSaveSlot());
			return clone;
		}
	}
}
