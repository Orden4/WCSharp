using System;
using System.Collections.Generic;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.Shared
{
	/// <summary>
	/// Defines a number of miscellaneous useful methods and constants. 
	/// </summary>
	public static class Util
	{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
		private static readonly location location = Location(0, 0);

		/// <summary>
		/// This multiplier will translate GUI-like floating text size values into the values Warcraft III expects them to be.
		/// </summary>
		public const float TEXT_SIZE_MULTIPLIER = 0.023f / 10.0f;
		/// <summary>
		/// This multiplier will translate GUI-like floating text velocity values into the values Warcraft III expects them to be.
		/// </summary>
		public const float TEXT_VELOCITY_MULTIPLIER = 0.071f / 128.0f;
		/// <summary>
		/// A shortcut for <see cref="Deg2Rad(float)"/>.
		/// </summary>
		public const float DEG2RAD = PI / 180.0f;
		/// <summary>
		/// A shortcut for <see cref="Rad2Deg(float)"/>.
		/// </summary>
		public const float RAD2DEG = 180.0f / PI;
		/// <summary>
		/// A shortcut for <see cref="Blizzard.bj_PI"/>.
		/// </summary>
		public const float PI = 3.14159274f;

		/// <summary>
		/// Outputs the given data as text to the local player at the default position.
		/// </summary>
		public static void Debug(object obj)
		{
			DisplayTextToPlayer(GetLocalPlayer(), 0, 0, obj.ToString());
		}

		/// <summary>
		/// Displays the given text to everyone at the default position.
		/// </summary>
		/// @CSharpLua.Template = "DisplayTextToPlayer(GetLocalPlayer(), 0, 0, {0})"
		public static extern void DisplayTextToAll(string text);

		/// <summary>
		/// Calculates the distance from (<paramref name="x1"/>, <paramref name="y1"/>) to (<paramref name="x2"/>, <paramref name="y2"/>).
		/// </summary>
		public static float DistanceBetweenPoints(float x1, float y1, float x2, float y2)
		{
			var diffx = x1 - x2;
			var diffy = y1 - y2;
			return SquareRoot((diffx * diffx) + (diffy * diffy));
		}

		/// <summary>
		/// Calculates the distance from <paramref name="source"/> unit to (<paramref name="x2"/>, <paramref name="y2"/>).
		/// </summary>
		public static float DistanceBetweenPoints(unit source, float x2, float y2)
		{
			var dx = GetUnitX(source) - x2;
			var dy = GetUnitY(source) - y2;
			return SquareRoot((dx * dx) + (dy * dy));
		}

		/// <summary>
		/// Calculates the distance from (<paramref name="x1"/>, <paramref name="y1"/>) to <paramref name="target"/> unit.
		/// </summary>
		public static float DistanceBetweenPoints(float x1, float y1, unit target)
		{
			var dx = x1 - GetUnitX(target);
			var dy = y1 - GetUnitY(target);
			return SquareRoot((dx * dx) + (dy * dy));
		}

		/// <summary>
		/// Calculates the distance from <paramref name="source"/> unit to <paramref name="target"/> unit.
		/// </summary>
		public static float DistanceBetweenPoints(unit source, unit target)
		{
			var dx = GetUnitX(source) - GetUnitX(target);
			var dy = GetUnitY(source) - GetUnitY(target);
			return SquareRoot((dx * dx) + (dy * dy));
		}

		/// <summary>
		/// Calculates the angle in degrees from (<paramref name="x1"/>, <paramref name="y1"/>) to (<paramref name="x2"/>, <paramref name="y2"/>).
		/// </summary>
		/// @CSharpLua.Template = "(180 + (57.2957764 * Atan2({1} - {3}, {0} - {2})))"
		public static extern float AngleBetweenPoints(float x1, float y1, float x2, float y2);

		/// <summary>
		/// Calculates the angle in degrees from <paramref name="source"/> unit to (<paramref name="x2"/>, <paramref name="y2"/>).
		/// </summary>
		public static float AngleBetweenPoints(unit source, float x2, float y2)
		{
			return 180 + (RAD2DEG * Atan2(GetUnitY(source) - y2, GetUnitX(source) - x2));
		}

		/// <summary>
		/// Calculates the angle in degrees from (<paramref name="x1"/>, <paramref name="y1"/>) to <paramref name="target"/> unit.
		/// </summary>
		public static float AngleBetweenPoints(float x1, float y1, unit target)
		{
			return 180 + (RAD2DEG * Atan2(y1 - GetUnitY(target), x1 - GetUnitX(target)));
		}

		/// <summary>
		/// Calculates the angle in degrees from <paramref name="source"/> unit to <paramref name="target"/> unit.
		/// </summary>
		public static float AngleBetweenPoints(unit source, unit target)
		{
			return 180 + (RAD2DEG * Atan2(GetUnitY(source) - GetUnitY(target), GetUnitX(source) - GetUnitX(target)));
		}

		/// <summary>
		/// Calculates the angle in radians from (<paramref name="x1"/>, <paramref name="y1"/>) to (<paramref name="x2"/>, <paramref name="y2"/>).
		/// </summary>
		/// @CSharpLua.Template = "(3.14159274 + Atan2({1} - {3}, {0} - {2}))"
		public static extern float AngleBetweenPointsRad(float x1, float y1, float x2, float y2);

		/// <summary>
		/// Calculates the angle in radians from <paramref name="source"/> unit to (<paramref name="x2"/>, <paramref name="y2"/>).
		/// </summary>
		public static float AngleBetweenPointsRad(unit source, float x2, float y2)
		{
			return PI + Atan2(GetUnitY(source) - y2, GetUnitX(source) - x2);
		}

		/// <summary>
		/// Calculates the angle in radians from (<paramref name="x1"/>, <paramref name="y1"/>) to <paramref name="target"/> unit.
		/// </summary>
		public static float AngleBetweenPointsRad(float x1, float y1, unit target)
		{
			return PI + Atan2(y1 - GetUnitY(target), x1 - GetUnitX(target));
		}

		/// <summary>
		/// Calculates the angle in radians from <paramref name="source"/> unit to <paramref name="target"/> unit.
		/// </summary>
		public static float AngleBetweenPointsRad(unit source, unit target)
		{
			return PI + Atan2(GetUnitY(source) - GetUnitY(target), GetUnitX(source) - GetUnitX(target));
		}

		/// <summary>
		/// Calculates a point that is the given <paramref name="offset"/> away from (<paramref name="x"/>, <paramref name="y"/>) at the target <paramref name="degrees"/>.
		/// </summary>
		public static (float x, float y) PositionWithPolarOffset(float x, float y, float offset, float degrees)
		{
			return (
				x + (offset * Cos(DEG2RAD * degrees)),
				y + (offset * Sin(DEG2RAD * degrees))
			);
		}

		/// <summary>
		/// Calculates an x-coordinate that is the given <paramref name="offset"/> away from <paramref name="x"/> at the target <paramref name="degrees"/>.
		/// </summary>
		/// @CSharpLua.Template = "({0} + ({1} * Cos(0.0174532924 * {2})))"
		public static extern float PositionWithPolarOffsetX(float x, float offset, float degrees);

		/// <summary>
		/// Calculates a y-coordinate that is the given <paramref name="offset"/> away from <paramref name="y"/> at the target <paramref name="degrees"/>.
		/// </summary>
		/// @CSharpLua.Template = "({0} + ({1} * Sin(0.0174532924 * {2})))"
		public static extern float PositionWithPolarOffsetY(float y, float offset, float degrees);

		/// <summary>
		/// Calculates a point that is the given <paramref name="offset"/> away from (<paramref name="x"/>, <paramref name="y"/>) at the target <paramref name="radians"/>.
		/// </summary>
		public static (float x, float y) PositionWithPolarOffsetRad(float x, float y, float offset, float radians)
		{
			return (
				x + (offset * Cos(radians)),
				y + (offset * Sin(radians))
			);
		}

		/// <summary>
		/// Calculates an x-coordinate that is the given <paramref name="offset"/> away from <paramref name="x"/> at the target <paramref name="radians"/>.
		/// </summary>
		/// @CSharpLua.Template = "({0} + ({1} * Cos({2})))"
		public static extern float PositionWithPolarOffsetRadX(float x, float offset, float radians);

		/// <summary>
		/// Calculates a y-coordinate that is the given <paramref name="offset"/> away from <paramref name="y"/> at the target <paramref name="radians"/>.
		/// </summary>
		/// @CSharpLua.Template = "({0} + ({1} * Sin({2})))"
		public static extern float PositionWithPolarOffsetRadY(float y, float offset, float radians);

		/// <summary>
		/// <para>Determines whether the attacker is behind the attacked with the given tolerance in degrees.</para>
		/// <para>A tolerance of 360 would mean the target can be attacked from anywhere while being considered "behind".</para>
		/// </summary>
		/// <param name="attacker">The unit performing the attack.</param>
		/// <param name="attacked">The unit being attacked.</param>
		/// <param name="tolerance">In degrees.</param>
		public static bool IsAttackerBehindUnit(unit attacker, unit attacked, float tolerance)
		{
			return IsAttackerBehindUnit(GetUnitX(attacker), GetUnitY(attacker), attacked, tolerance);
		}

		/// <summary>
		/// <para>Determines whether the attacker is behind the attacked with the given tolerance in degrees.</para>
		/// <para>A tolerance of 360 would mean the target can be attacked from anywhere while being considered "behind".</para>
		/// </summary>
		/// <param name="attackerX">The X position of the attacker.</param>
		/// <param name="attackerY">The Y position of the attacker.</param>
		/// <param name="attacked">The unit being attacked.</param>
		/// <param name="tolerance">In degrees.</param>
		public static bool IsAttackerBehindUnit(float attackerX, float attackerY, unit attacked, float tolerance)
		{
			var attackerAngle = AngleBetweenPoints(attackerX, attackerY, GetUnitX(attacked), GetUnitY(attacked));
			return IsAttackerBehindUnit(attackerAngle, attacked, tolerance);
		}

		/// <summary>
		/// <para>Determines whether the attacker is behind the attacked with the given tolerance in degrees.</para>
		/// <para>A tolerance of 360 would mean the target can be attacked from anywhere while being considered "behind".</para>
		/// </summary>
		/// <param name="attackerAngle">The angle of the attacker.</param>
		/// <param name="attacked">The unit being attacked.</param>
		/// <param name="tolerance">In degrees.</param>
		public static bool IsAttackerBehindUnit(float attackerAngle, unit attacked, float tolerance)
		{
			var attackedAngle = GetUnitFacing(attacked);
			var maxAllowedAngle = 360 - (0.5f * tolerance);
			var minAllowedAngle = 0.5f * tolerance;

			var difference = Math.Abs(attackerAngle - attackedAngle);

			return difference < minAllowedAngle || difference > maxAllowedAngle;
		}

		/// <summary>
		/// <para>Determines whether the attacker is in front of the attacked with the given tolerance in degrees.</para>
		/// <para>A tolerance of 360 means the target can be attacked from anywhere while being considered "infront".</para>
		/// </summary>
		/// <param name="attacker">The unit performing the attack.</param>
		/// <param name="attacked">The unit being attacked.</param>
		/// <param name="tolerance">In degrees.</param>
		public static bool IsAttackerInfrontUnit(unit attacker, unit attacked, float tolerance)
		{
			var attackerAngle = AngleBetweenPoints(GetUnitX(attacked), GetUnitY(attacked), GetUnitX(attacker), GetUnitY(attacker));
			var attackedAngle = GetUnitFacing(attacked);
			var maxAllowedAngle = 360 - (0.5f * tolerance);
			var minAllowedAngle = 0.5f * tolerance;

			var difference = Math.Abs(attackerAngle - attackedAngle);

			return difference < minAllowedAngle || difference > maxAllowedAngle;
		}

		/// <summary>
		/// Returns all players matching the given <paramref name="playerslotstate"/> and <paramref name="mapcontrol"/>.
		/// </summary>
		/// <param name="playerslotstate">The <see cref="playerslotstate"/> that players should have. Defaults to <see cref="PLAYER_SLOT_STATE_PLAYING"/>.</param>
		/// <param name="mapcontrol">The <see cref="mapcontrol"/> that players should have. Defaults to <see cref="MAP_CONTROL_USER"/>.</param>
		/// <returns></returns>
		public static IEnumerable<player> EnumeratePlayers(playerslotstate playerslotstate = null, mapcontrol mapcontrol = null)
		{
			playerslotstate ??= PLAYER_SLOT_STATE_PLAYING;
			mapcontrol ??= MAP_CONTROL_USER;

			var maxPlayers = GetBJMaxPlayers();
			for (var i = 0; i < maxPlayers; i++)
			{
				var player = Player(i);
				if (GetPlayerSlotState(player) == playerslotstate && GetPlayerController(player) == mapcontrol)
				{
					yield return player;
				}
			}
		}

		/// <summary>
		/// Returns all players.
		/// </summary>
		public static IEnumerable<player> EnumeratePlayers()
		{
			var maxPlayers = GetBJMaxPlayers();
			for (var i = 0; i < maxPlayers; i++)
			{
				var player = Player(i);
				yield return player;
			}
		}

		/// <summary>
		/// Creates a "damage text" style of floating text at the target location.
		/// <para>Size is expected to be GUI-like values (it gets multiplied by <see cref="TEXT_SIZE_MULTIPLIER"/>).</para>
		/// <para>By default, the text will start to fade after 2 seconds, and be fully removed after 4 seconds.</para>
		/// </summary>
		/// <param name="damage">The damage number to display (will round to whole numbers).</param>
		/// <param name="isHeal">If true, will color green.</param>
		/// <param name="isCritical">If true, will add an exclamation mark.</param>
		/// <param name="size">The size of the text. See GUI.</param>
		/// <param name="x">The x position that the text should be created at.</param>
		/// <param name="y">The y position that the text should be created at.</param>
		/// <param name="height">The height that the text should be created at, relative to the target (x, y) position.</param>
		public static texttag CreateDamageText(float damage, bool isHeal, bool isCritical, float size, float x, float y, float height)
		{
			var textTag = CreateTextTag();
			var str = $"{MathRound(damage)}";
			if (isHeal)
			{
				SetTextTagColor(textTag, 0, 255, 0, 255);
				str = $"+{str}";
			}
			else
			{
				SetTextTagColor(textTag, 255, 0, 0, 255);
			}

			if (isCritical)
			{
				str = $"{str}!";
			}

			SetTextTagText(textTag, str, size * TEXT_SIZE_MULTIPLIER);
			SetTextTagPos(textTag, x, y, height);
			SetTextTagAge(textTag, 0);
			SetTextTagVelocity(textTag, 0, 90 * TEXT_VELOCITY_MULTIPLIER);
			SetTextTagLifespan(textTag, 4);
			SetTextTagFadepoint(textTag, 2);
			SetTextTagPermanent(textTag, false);
			SetTextTagVisibility(textTag, true);

			return textTag;
		}

		/// <summary>
		/// Creates a floating text at the target location.
		/// <para>Size is expected to be GUI-like values (it gets multiplied by <see cref="TEXT_SIZE_MULTIPLIER"/>).</para>
		/// <para>By default, the text will start to fade after 2 seconds, and be fully removed after 4 seconds.</para>
		/// </summary>
		/// <param name="text">The text to display.</param>
		/// <param name="size">The size of the text. See GUI.</param>
		/// <param name="x">The x position that the text should be created at.</param>
		/// <param name="y">The y position that the text should be created at.</param>
		/// <param name="height">The height that the text should be created at, relative to the target (x, y) position.</param>
		/// <param name="red">The red value of the text. Should be in the range of 0 (none) to 255 (pure red).</param>
		/// <param name="green">The green value of the text. Should be in the range of 0 (none) to 255 (pure green).</param>
		/// <param name="blue">The blue value of the text. Should be in the range of 0 (none) to 255 (pure blue).</param>
		public static texttag CreateFloatText(string text, float size, float x, float y, float height, int red, int green, int blue)
		{
			var textTag = CreateTextTag();
			SetTextTagText(textTag, text, size * TEXT_SIZE_MULTIPLIER);
			SetTextTagPos(textTag, x, y, height);
			SetTextTagAge(textTag, 0);
			SetTextTagColor(textTag, red, green, blue, 255);
			SetTextTagVelocity(textTag, 0, 90 * TEXT_VELOCITY_MULTIPLIER);
			SetTextTagLifespan(textTag, 4);
			SetTextTagFadepoint(textTag, 2);
			SetTextTagPermanent(textTag, false);
			SetTextTagVisibility(textTag, true);

			return textTag;
		}

		/// <summary>
		/// Retrieves the LocationZ at the given (X, Y) coordinates.
		/// <para>Re-uses an internal location to provide a faster and easier solution to <see cref="GetLocationZ(location)"/>.</para>
		/// </summary>
		public static float GetZ(float x, float y)
		{
			MoveLocation(location, x, y);
			return GetLocationZ(location);
		}
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	}
}
