using WCSharp.Utils;

namespace WCSharp.SaveLoad
{
	internal class Save
	{
		public int Version { get; set; }
		public int HashCode { get; set; }
		public string PlayerName { get; set; }
		public string SaveData { get; set; }

		public void Encrypt()
		{
			SaveData = Base64.ToBase64(SaveData);
		}

		public void Decrypt()
		{
			SaveData = Base64.FromBase64(SaveData);
		}

		public int GetSaveHash(int hash1, int hash2, bool bindSavesToPlayerName, string salt)
		{
			unchecked
			{
				var hash = HashString(hash1, hash2, SaveData);
				if (bindSavesToPlayerName)
				{
					hash = HashString(hash, hash2, PlayerName);
				}
				hash = HashString(hash, hash2, salt);

				return hash;
			}
		}

		private static int HashString(int hash, int hash2, string @string)
		{
			unchecked
			{
				foreach (var ch in @string)
				{
					hash = (hash * hash2) ^ ch;
				}

				return hash;
			}

		}
	}
}
