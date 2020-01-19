using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class CrystalisedEtherianMana : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Crystalised Etherian Mana");
			Tooltip.SetDefault("A solidified piece of Etherian Mana");
		}

		public override void SetDefaults() 
		{
			item.value = 10000;
			item.rare = 2;
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