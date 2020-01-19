using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class EyeOfTheStorm : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Eye of the Storm");
			Tooltip.SetDefault("Applies Electrified to all Attacks");
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
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RainCloud, 50);
			recipe.AddIngredient(ItemID.SuspiciousLookingEye);
			recipe.AddIngredient(ItemID.WaterBucket, 3);
			recipe.AddIngredient(ItemID.Cog, 5);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}