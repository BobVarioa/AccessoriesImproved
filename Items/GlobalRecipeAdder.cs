using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class GlobalRecipeAdder : GlobalItem
	{
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PharaohsMask); // Pharaoh's Mask
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>(), 2);  
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PharaohsRobe); // Pharaoh's Robe
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>(), 2);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlyingCarpet); // FLying Carpet
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>(), 4);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SnakeBanner); // Snake Banner
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.OmegaBanner); // Omega Banner
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AnkhBanner); // Ankh Banner
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MummyMask); // Mummy Mask
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MummyShirt); // Mummy Shirt
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MummyPants); // Mummy Pants
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ModContent.ItemType<PharaohsPhabric>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<CrystalizedEtherianMana>(), 1); // Crystised Etherian Mana
			recipe.AddTile(TileID.WarTable);
			recipe.SetResult(ItemID.DD2EnergyCrystal, 50);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<CrystalizedEtherianMana>(), 5); // Crystised Etherian Mana
			recipe.AddTile(TileID.WarTable);
			recipe.SetResult(ItemID.DD2ElderCrystal);
			recipe.AddRecipe();
		}
	}
}