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

		/// @CSharpLua.Template = "ForceAddPlayer({this}, {0})"
		public extern void Add(player player);
		/// @CSharpLua.Template = "ForceRemovePlayer({this}, {0})"
		public extern void Remove(player player);
		/// @CSharpLua.Template = "BlzForceHasPlayer({this}, {0})"
		public extern void Contains(player player);
		/// @CSharpLua.Template = "ForceClear({this})"
		public extern void Clear();
		/// @CSharpLua.Template = "ForceEnumPlayers({this}, {0})"
		public extern void EnumPlayers(boolexpr filter = null);
		/// @CSharpLua.Template = "ForceEnumAllies({this}, {0}, {1})"
		public extern void EnumAllies(player player, boolexpr filter = null);
		/// @CSharpLua.Template = "ForceEnumEnemies({this}, {0}, {1})"
		public extern void EnumEnemies(player player, boolexpr filter = null);
		/// @CSharpLua.Template = "ForForce({this})"
		public extern void ForEach(Action action);
		/// @CSharpLua.Template = "DestroyForce({this})"
		public extern void Dispose();
	}
}
