using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class HeartOfTheStorm : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Heart of the Storm");
			Tooltip.SetDefault("Can Toggle Rain");
		}

		public override void SetDefaults()
		{
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<AccessPlayer>().ToggleRain = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.NimbusRod);
			recipe.AddIngredient(ItemID.LifeCrystal, 3);
			recipe.AddIngredient(ItemID.WaterBucket, 2);
			recipe.AddIngredient(ItemID.Cog, 5);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}