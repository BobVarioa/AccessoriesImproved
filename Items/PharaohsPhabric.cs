using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class PharaohsPhabric : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Pharaoh's Fabric");
			Tooltip.SetDefault("An Anicent Cloth");
		}

		public override void SetDefaults() 
		{
			item.value = 10000;
			item.rare = 2;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PharaohsMask, 2); // Pharaoh's Mask
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PharaohsRobe, 2); // Pharaoh's Robe
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlyingCarpet, 4); // FLying Carpet
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SnakeBanner, 1); // Snake Banner
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.OmegaBanner, 1); // Omega Banner
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AnkhBanner, 1); // Ankh Banner
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MummyMask, 1); // Mummy Mask
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MummyShirt, 1); // Mummy Shirt
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MummyPants, 1); // Mummy Pants
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AncientBattleArmorMaterial, 1); // Normal Recipe
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this, 10);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AncientCloth, 2); // Normal Recipe
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}