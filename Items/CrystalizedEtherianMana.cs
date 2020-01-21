using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class CrystalizedEtherianMana : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Crystalized Etherian Mana");
			Tooltip.SetDefault("A solidified piece of Etherian Mana");
		}

		public override void SetDefaults() 
		{
			item.value = Item.buyPrice(0, 0, 25, 0);
			item.rare = 0;
			item.maxStack = 999;
			item.expert = false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DD2EnergyCrystal, 50); // Normal Recipe
			recipe.AddTile(TileID.WarTable);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}