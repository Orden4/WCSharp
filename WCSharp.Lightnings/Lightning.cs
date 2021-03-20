﻿using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Lightnings
{
	public class Lightning : IPeriodicAction
	{
		/// <summary>
		/// Set this to false to end the lightning early. Note that you MUST call <see cref="Dispose"/> if you do so.
		/// </summary>
		public bool Active { get; set; }
		/// <summary>
		/// The caster of the lightning. Setting this means that the lightning will follow the caster when the caster moves.
		/// </summary>
		public unit Caster { get; set; }
		/// <summary>
		/// The X coordinate from which this lightning was fired. While <see cref="Caster"/> is alive, this will automatically be updated.
		/// </summary>
		public float CasterX { get; set; }
		/// <summary>
		/// The Y coordinate from which this lightning was fired. While <see cref="Caster"/> is alive, this will automatically be updated.
		/// </summary>
		public float CasterY { get; set; }
		/// <summary>
		/// The height that this lightning should originate from. By default, this is the ground.
		/// </summary>
		public float CasterHeightOffset { get; set; }
		/// <summary>
		/// The target of the lightning. Setting this means that the lightning will follow the target when the target moves.
		/// </summary>
		public unit Target { get; set; }
		/// <summary>
		/// The X coordinate that this lightning is targeting. While <see cref="Target"/> is alive, this will automatically be updated.
		/// </summary>
		public float TargetX { get; set; }
		/// <summary>
		/// The Y coordinate that this lightning is targeting. While <see cref="Target"/> is alive, this will automatically be updated.
		/// </summary>
		public float TargetY { get; set; }
		/// <summary>
		/// The height that this lightning should aim at. By default, this is the ground.
		/// </summary>
		public float TargetHeightOffset { get; set; }
		/// <summary>
		/// The red color of this lightning. Setting this to 0 means all red will be removed from the lightning.
		/// </summary>
		public float Red { get; set; } = 1;
		/// <summary>
		/// The green color of this lightning. Setting this to 0 means all green will be removed from the lightning.
		/// </summary>
		public float Green { get; set; } = 1;
		/// <summary>
		/// The blue color of this lightning. Setting this to 0 means all blue will be removed from the lightning.
		/// </summary>
		public float Blue { get; set; } = 1;
		/// <summary>
		/// The alpha (transparency) of this lightning. Setting this to 0 means the lightning is invisible.
		/// </summary>
		public float Alpha { get; set; } = 1;
		/// <summary>
		/// The duration that this lightning should last in total.
		/// </summary>
		public float Duration { get; set; }
		/// <summary>
		/// The length of time over which the lightning will fade.
		/// </summary>
		public float FadeDuration { get; set; }

		private float targetZ;
		private float casterZ;
		private float age;
		private float transparencyRate;

		private readonly string name;

		/// <summary>
		/// The actual lightning effect.
		/// </summary>
		protected lightning lightning;

		public Lightning(string name, unit caster, unit target)
		{
			this.name = name;
			this.casterZ = BlzGetUnitZ(caster) + GetUnitFlyHeight(caster);
			this.targetZ = BlzGetUnitZ(target) + GetUnitFlyHeight(target);

			Caster = caster;
			CasterX = GetUnitX(caster);
			CasterY = GetUnitY(caster);

			Target = target;
			TargetX = GetUnitX(target);
			TargetY = GetUnitY(target);
		}

		public Lightning(string name, unit caster, float targetX, float targetY)
		{
			this.name = name;
			this.casterZ = BlzGetUnitZ(caster) + GetUnitFlyHeight(caster);
			var location = Location(targetX, targetY);
			this.targetZ = GetLocationZ(location);
			RemoveLocation(location);

			Caster = caster;
			CasterX = GetUnitX(caster);
			CasterY = GetUnitY(caster);

			TargetX = targetX;
			TargetY = targetY;
		}

		public Lightning(string name, float casterX, float casterY, unit target)
		{
			this.name = name;
			var location = Location(casterX, casterY);
			this.casterZ = GetLocationZ(location);
			RemoveLocation(location);
			this.targetZ = BlzGetUnitZ(target) + GetUnitFlyHeight(target);

			CasterX = casterX;
			CasterY = casterY;

			Target = target;
			TargetX = GetUnitX(target);
			TargetY = GetUnitY(target);
		}

		public Lightning(string name, float casterX, float casterY, float targetX, float targetY)
		{
			this.name = name;
			var location = Location(casterX, casterY);
			this.casterZ = GetLocationZ(location);
			RemoveLocation(location);
			location = Location(targetX, targetY);
			this.targetZ = GetLocationZ(location);
			RemoveLocation(location);

			CasterX = casterX;
			CasterY = casterY;

			TargetX = targetX;
			TargetY = targetY;
		}

		internal void Start()
		{
			this.lightning = AddLightning(this.name, true, CasterX, CasterY, TargetX, TargetY);
			MoveLightningEx(this.lightning, true, CasterX, CasterY, this.casterZ + CasterHeightOffset, TargetX, TargetY, this.casterZ + TargetHeightOffset);
			SetLightningColor(this.lightning, Red, Green, Blue, Alpha);
			this.transparencyRate = FadeDuration > 0 ? Alpha / FadeDuration * PeriodicEvents.SYSTEM_INTERVAL : Alpha;
			this.age = 0;
		}

		public void Action()
		{
			if (Caster != null)
			{
				if (UnitAlive(Caster))
				{
					CasterX = GetUnitX(Caster);
					CasterY = GetUnitY(Caster);
					this.casterZ = BlzGetUnitZ(Caster) + GetUnitFlyHeight(Caster);
				}
				else
				{
					Caster = null;
				}
			}

			if (Target != null)
			{
				if (UnitAlive(Target))
				{
					TargetX = GetUnitX(Target);
					TargetY = GetUnitY(Target);
					this.targetZ = BlzGetUnitZ(Target) + GetUnitFlyHeight(Target);
				}
				else
				{
					Target = null;
				}
			}

			MoveLightningEx(this.lightning, true, CasterX, CasterY, this.casterZ + CasterHeightOffset, TargetX, TargetY, this.targetZ + TargetHeightOffset);

			this.age += PeriodicEvents.SYSTEM_INTERVAL;
			if (this.age > Duration - FadeDuration)
			{
				Alpha -= this.transparencyRate;
				SetLightningColor(this.lightning, Red, Green, Blue, Alpha);
			}

			if (this.age >= Duration)
			{
				Active = false;
				Dispose();
			}
		}

		/// <summary>
		/// For lightnings that last until cancelled (meaning duration is excessively high), this method can be used to start the fade out process when desired.
		/// </summary>
		public void StartFade()
		{
			this.age = Duration - FadeDuration;
		}

		/// <summary>
		/// This method MUST be called if you are artifically ending the lightning early by forcibly setting <see cref="Active"/> to false.
		/// </summary>
		public void Dispose()
		{
			DestroyLightning(this.lightning);
		}
	}
}