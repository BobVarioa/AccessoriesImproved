using AccessoriesImproved.Buffs;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class AccessPlayer : ModPlayer
	{
		// Weather Toggle
		public bool ToggleRain = false;
		public bool ToggleSandstorm = false;
		public bool ToggleSnowstorm = false;

		// Other
		public bool EyeOfTheStorm = false;
		public bool EternalFlame = false;
		public bool BetsyEgg = false;
		public bool ToggleDjinnsCurse = false;
		public bool slowfallOn = false;

		public bool DestroyerGauntlet = false;
		public bool VortexBracers = false;


		public override void ResetEffects()
		{
			// Weather Toggle
			ToggleRain = false;
			ToggleSandstorm = false;
			ToggleSnowstorm = false;

			//Other
			EyeOfTheStorm = false;
			EternalFlame = false;
			BetsyEgg = false;
			ToggleDjinnsCurse = false;

			DestroyerGauntlet = false;

			if (slowfallOn == true)
			{
				player.slowFall = true;
			}
			else if (slowfallOn == false)
			{
				player.slowFall = false;
			}
		}

		public override void ProcessTriggers(TriggersSet triggersSet)
		{
			if (AccessoriesImproved.DjinnsCurseToggle.JustPressed && ToggleDjinnsCurse )
			{
				switch (slowfallOn)
				{
					case false:
						slowfallOn = true;
						Main.NewText("Your legs turn to a mist");
						break;
					case true:
						slowfallOn = false;
						Main.NewText("Your legs regain their worldly form");
						break;
				}
			}

			if (AccessoriesImproved.WeatherToggle.JustPressed && ToggleRain && !(player.ZoneSnow || (player.ZoneDesert || player.ZoneSandstorm)))
			{
				switch ( Main.raining )
				{
					case false:
						StartRain();
						Main.cloudBGActive = 1f;
						Main.cloudBGAlpha = 1f;
						Main.numClouds = Main.cloudLimit;
						Main.NewText("Rain pours down from above");
						break;
					case true:
						StopRain();
						Main.cloudBGActive = 0f;
						Main.cloudBGAlpha = 0f;
						Main.numClouds = 0;
						Main.NewText("The rain slowly fades away");
						break;
				}
			}
			if (AccessoriesImproved.WeatherToggle.JustPressed && ToggleSandstorm && (player.ZoneDesert || player.ZoneSandstorm))
			{
				switch (Sandstorm.Happening)
				{
					case false:
						Sandstorm.Happening = true;
						Main.NewText("Sandstorm On");
						break;
					case true:
						Sandstorm.Happening = false;
						Main.NewText("Sandstorm Off");
						break;
				}
			}

			if (AccessoriesImproved.WeatherToggle.JustPressed && ToggleSnowstorm && player.ZoneSnow)
			{
				switch (Main.raining)
				{
					case false:
						StartRain();
						Main.cloudBGActive = 1f;
						Main.cloudBGAlpha = 1f;
						Main.numClouds = Main.cloudLimit;
						Main.NewText("A blizzard begins brewing");
						break;
					case true:
						StopRain();
						Main.cloudBGActive = 0f;
						Main.cloudBGAlpha = 0f;
						Main.numClouds = 0;
						Main.NewText("The snowy wings fade away");
						break;
				}
			}
		}
		// Code Borrowed From : https://github.com/dragon3025/Reduced-Grinding/blob/master/Items/Rain_Potion.cs
		private static void StopRain()
		{
			Main.rainTime = 0;
			Main.raining = false;
			Main.maxRaining = 0f;
		}

		private static void StartRain()
		{
			int num = 86400;
			int num2 = num / 24;
			Main.rainTime = Main.rand.Next(num2 * 8, num);
			if (Main.rand.Next(3) == 0)
			{
				Main.rainTime += Main.rand.Next(0, num2);
			}
			if (Main.rand.Next(4) == 0)
			{
				Main.rainTime += Main.rand.Next(0, num2 * 2);
			}
			if (Main.rand.Next(5) == 0)
			{
				Main.rainTime += Main.rand.Next(0, num2 * 2);
			}
			if (Main.rand.Next(6) == 0)
			{
				Main.rainTime += Main.rand.Next(0, num2 * 3);
			}
			if (Main.rand.Next(7) == 0)
			{
				Main.rainTime += Main.rand.Next(0, num2 * 4);
			}
			if (Main.rand.Next(8) == 0)
			{
				Main.rainTime += Main.rand.Next(0, num2 * 5);
			}
			float num3 = 1f;
			if (Main.rand.Next(2) == 0)
			{
				num3 += 0.05f;
			}
			if (Main.rand.Next(3) == 0)
			{
				num3 += 0.1f;
			}
			if (Main.rand.Next(4) == 0)
			{
				num3 += 0.15f;
			}
			if (Main.rand.Next(5) == 0)
			{
				num3 += 0.2f;
			}
			Main.rainTime = (int)((float)Main.rainTime * num3);
			ChangeRain();
			Main.raining = true;
		}

		private static void ChangeRain()
		{
			if (Main.cloudBGActive >= 1f || (double)Main.numClouds > 150.0)
			{
				if (Main.rand.Next(3) == 0)
				{
					Main.maxRaining = (float)Main.rand.Next(20, 90) * 0.01f;
					return;
				}
				Main.maxRaining = (float)Main.rand.Next(40, 90) * 0.01f;
				return;
			}
			else if ((double)Main.numClouds > 100.0)
			{
				if (Main.rand.Next(3) == 0)
				{
					Main.maxRaining = (float)Main.rand.Next(10, 70) * 0.01f;
					return;
				}
				Main.maxRaining = (float)Main.rand.Next(20, 60) * 0.01f;
				return;
			}
			else
			{
				if (Main.rand.Next(3) == 0)
				{
					Main.maxRaining = (float)Main.rand.Next(5, 40) * 0.01f;
					return;
				}
				Main.maxRaining = (float)Main.rand.Next(5, 30) * 0.01f;
				return;
			}
		}
		// End Code Borrowed

		// Code Borrowed From : https://github.com/Werebearguy/AssortedCrazyThings/blob/master/AssPlayer.cs
		private void ApplyHitDebuffs(Entity victim)
		{
			if (victim is NPC)
			{
				if (EternalFlame)
				{
					((NPC)victim).AddBuff(BuffID.OnFire, 60);
					((NPC)victim).AddBuff(BuffID.CursedInferno, 60);
				}
				if (BetsyEgg)
				{
					((NPC)victim).AddBuff(BuffID.OnFire, 60);
					((NPC)victim).AddBuff(BuffID.CursedInferno, 60);
					((NPC)victim).AddBuff(BuffID.BetsysCurse, 60);
				}
				if (EyeOfTheStorm)
				{
					((NPC)victim).AddBuff(ModContent.BuffType<Electrifed>(), 60);
				}
			}
		}

		public override void ModifyHitNPC(Item item, NPC target, ref int damage, ref float knockback, ref bool crit)
		{
			ApplyHitDebuffs(target);
		}

		public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{
			ApplyHitDebuffs(target);
		}

		// End Code Borrowed
		public float GetWeaponKnockback(Item sItem, float KnockBack)
		{
			if (sItem.melee && DestroyerGauntlet)
			{
				KnockBack *= 2.5f;
			}
			return KnockBack;
		}
	}
}