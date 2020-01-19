using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class GlobalRecipeAdder : GlobalItem
	{
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PharaohsMask, 2); // Pharaoh's Mask
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());  
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PharaohsRobe, 2); // Pharaoh's Robe
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlyingCarpet, 4); // FLying Carpet
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SnakeBanner, 1); // Snake Banner
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.OmegaBanner, 1); // Omega Banner
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AnkhBanner, 1); // Ankh Banner
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MummyMask, 1); // Mummy Mask
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MummyShirt, 1); // Mummy Shirt
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MummyPants, 1); // Mummy Pants
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<CrystalisedEtherianMana>(), 1); // Crystised Etherian Mana
			recipe.AddTile(TileID.WarTable);
			recipe.SetResult(ItemID.DD2EnergyCrystal, 50);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<CrystalisedEtherianMana>(), 5); // Crystised Etherian Mana
			recipe.AddTile(TileID.WarTable);
			recipe.SetResult(ItemID.DD2ElderCrystal);
			recipe.AddRecipe();
		}
	}
}