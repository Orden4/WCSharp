using static War3Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// This class is identical to <see cref="BoundBuff"/>, except that it implements a default <see cref="OnStack"/> behaviour that better
	/// matches standard aura behaviour.
	/// <para>The <see cref="Buff.Stacks"/> property will be set to the number of aura bearers applying the aura.</para>
	/// </summary>
	public abstract class AuraBoundBuff : BoundBuff
	{
		/// <inheritdoc/>
		public AuraBoundBuff(unit caster, unit target) : base(caster, target)
		{
		}

		/// <summary>
		/// Executes whenever this buff receives a new stack via <see cref="BuffSystem.Add(Buff, StackBehaviour)"/>.
		/// <para>AuraBoundBuffs will always have their <see cref="Buff.Stacks"/> property set to the number of aura bearers applying the aura.</para>
		/// </summary>
		public sealed override StackResult OnStack(Buff newStack)
		{
			Stacks++;
			return StackResult.Stack;
		}
	}
}
