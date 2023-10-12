using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.Shared
{
	/// <summary>
	/// <para>Defines a number of miscellaneous useful methods. These methods are all inlined via the CSharpLua compiler for maximum
	/// performance, however as a result some arguments should not be "calculated" ones (i.e., it should already be calculated when given to
	/// this method, store it in a variable if needed) as otherwise the performance gain over the methods in <see cref="Util"/> is
	/// nullified.</para>
	/// <para>For methods not present in this one compared to <see cref="Util"/>, it means the <see cref="Util"/> variant is already safely
	/// inlined, or inlining is not possible.</para>
	/// <para>For the average user, I recommend just sticking to <see cref="Util"/> and not worrying about this variation.
	/// The speed difference is negligble and only a concern for heavy load systems.</para>
	/// </summary>
	/// @CSharpLua.Ignore
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	public class FastUtil
	{
		/// <summary>
		/// Calculates the distance from (<paramref name="x1"/>, <paramref name="y1"/>) to (<paramref name="x2"/>, <paramref name="y2"/>).
		/// <para>All parameters must be pre-calculated.</para>
		/// </summary>
		/// @CSharpLua.Template = "SquareRoot((({0} - {2}) * ({0} - {2})) + (({1} - {3}) * ({1} - {3})))"
		public static extern float DistanceBetweenPoints(float x1, float y1, float x2, float y2);

		/// <summary>
		/// Calculates the angle in degrees from <paramref name="source"/> unit to (<paramref name="x2"/>, <paramref name="y2"/>).
		/// <para><paramref name="source"/> must be pre-calculated.</para>
		/// </summary>
		/// @CSharpLua.Template = "(180 + (57.2957764 * Atan2(GetUnitY({0}) - {2}, GetUnitX({0}) - {1})))"
		public static extern float AngleBetweenPoints(unit source, float x2, float y2);

		/// <summary>
		/// Calculates the angle in degrees from (<paramref name="x1"/>, <paramref name="y1"/>) to <paramref name="target"/> unit.
		/// <para><paramref name="target"/> must be pre-calculated.</para>
		/// </summary>
		/// @CSharpLua.Template = "(180 + (57.2957764 * Atan2({1} - GetUnitY({2}), {0} - GetUnitX({2}))))"
		public static extern float AngleBetweenPoints(float x1, float y1, unit target);

		/// <summary>
		/// Calculates the angle in degrees from <paramref name="source"/> unit to <paramref name="target"/> unit.
		/// <para>All parameters must be pre-calculated.</para>
		/// </summary>
		/// @CSharpLua.Template = "(180 + (57.2957764 * Atan2(GetUnitY({0}) - GetUnitY({1}), GetUnitX({0}) - GetUnitX({1}))))"
		public static extern float AngleBetweenPoints(unit source, unit target);

		/// <summary>
		/// Calculates the angle in radians from <paramref name="source"/> unit to (<paramref name="x2"/>, <paramref name="y2"/>).
		/// <para><paramref name="source"/> must be pre-calculated.</para>
		/// </summary>
		/// @CSharpLua.Template = "(3.14159274 + Atan2(GetUnitY({0}) - {2}, GetUnitX({0}) - {1}))"
		public static extern float AngleBetweenPointsRad(unit source, float x2, float y2);

		/// <summary>
		/// Calculates the angle in radians from (<paramref name="x1"/>, <paramref name="y1"/>) to <paramref name="target"/> unit.
		/// <para><paramref name="target"/> must be pre-calculated.</para>
		/// </summary>
		/// @CSharpLua.Template = "(3.14159274 + Atan2({1} - GetUnitY({2}), {0} - GetUnitX({2})))"
		public static extern float AngleBetweenPointsRad(float x1, float y1, unit target);

		/// <summary>
		/// Calculates the angle in radians from <paramref name="source"/> unit to <paramref name="target"/> unit.
		/// <para>All parameters must be pre-calculated.</para>
		/// </summary>
		/// @CSharpLua.Template = "(3.14159274 + Atan2(GetUnitY({0}) - GetUnitY({1}), GetUnitX({0}) - GetUnitX({1})))"
		public static extern float AngleBetweenPointsRad(unit source, unit target);
	}
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
}
