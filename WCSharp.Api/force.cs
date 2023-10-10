using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class force : agent, IDisposable
	{
		internal force()
		{
		}

		/// @CSharpLua.Template = "CreateForce({0})"
		public static extern force Create();

		/// @CSharpLua.Template = "ForceAddPlayer({0}, {1})"
		public extern void Add(player player);
		/// @CSharpLua.Template = "ForceRemovePlayer({0}, {1})"
		public extern void Remove(player player);
		/// @CSharpLua.Template = "BlzForceHasPlayer({0}, {1})"
		public extern void Contains(player player);
		/// @CSharpLua.Template = "ForceClear({0})"
		public extern void Clear();
		/// @CSharpLua.Template = "ForceEnumPlayers({0}, {1})"
		public extern void EnumPlayers(boolexpr filter = null);
		/// @CSharpLua.Template = "ForceEnumAllies({0}, {1}, {2})"
		public extern void EnumAllies(player player, boolexpr filter = null);
		/// @CSharpLua.Template = "ForceEnumEnemies({0}, {1}, {2})"
		public extern void EnumEnemies(player player, boolexpr filter = null);
		/// @CSharpLua.Template = "ForForce({0})"
		public extern void ForEach(Action action);
		/// @CSharpLua.Template = "DestroyForce({0})"
		public extern void Dispose();
	}
}
