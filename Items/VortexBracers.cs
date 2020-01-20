using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class VortexBracers : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vortex Bracers");
			Tooltip.SetDefault("Increases view range for guns (Right click to zoom out) \n20 % increased ranged damage, critical strike chance and greatly increases arrow speed \n25 % chance to not consume arrows");
		}

		public override void SetDefaults()
		{
			item.value = Item.buyPrice(0, 25, 0, 0);
			item.rare = 10;
			item.maxStack = 1;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.scope = true;
			player.rangedDamage += 0.2f;
			player.rangedCrit += 20;
			player.ammoCost75 = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MagicQuiver);
			recipe.AddIngredient(ItemID.SniperScope);
			recipe.AddIngredient(ItemID.FragmentVortex, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}