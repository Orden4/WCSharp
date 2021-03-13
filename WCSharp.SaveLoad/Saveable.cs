using static War3Api.Common;

namespace WCSharp.SaveLoad
{
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
}
