using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class DesertStormGear : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Desert Storm Gear");
			Tooltip.SetDefault("Applies Electrified to all Attacks \nCan toggle Rain / Blizzards / Sandstorms \nPuts a shell around the owner when below 50% life that reduces damage \nGrants the ability to swim and greatly extends underwater breathing \nProvides light under water and extra mobility on ice \nProvides immunity to chill and freezing effects \nImmune to Desert Winds \nAllows the owner to float for a few seconds \nGrants a togglable slow fall in exchange for your feet");
		}

		public override void SetDefaults()
		{
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<AccessPlayer>().EyeOfTheStorm = true;
			player.GetModPlayer<AccessPlayer>().ToggleRain = true;
			player.GetModPlayer<AccessPlayer>().ToggleSnowstorm = true;
			player.buffImmune[BuffID.Frozen] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.arcticDivingGear = true;
			player.accFlipper = true;
			player.accDivingHelm = true;
			player.iceSkate = true;
			if (player.wet)
			{
				Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 0.9f, 0.2f, 0.6f);
			}
			player.AddBuff(62, 5);
			player.buffImmune[BuffID.WindPushed] = true;
			player.carpet = true;
			player.GetModPlayer<AccessPlayer>().ToggleDjinnsCurse = true;
			player.GetModPlayer<AccessPlayer>().ToggleSandstorm = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BlizzardDivingGear>());
			recipe.AddIngredient(ModContent.ItemType<PharaohsPhacemask>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}