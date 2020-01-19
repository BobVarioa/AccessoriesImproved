using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class DesertBandana : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Desert Bandana");
			Tooltip.SetDefault("Immune to Desert Winds \nAllows the owner to float for a few seconds");
		}

		public override void SetDefaults()
		{
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.buffImmune[BuffID.WindPushed] = true;
			player.carpet = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<PharaohsPhabric>(), 5);
			recipe.AddIngredient(ItemID.FlyingCarpet);
			recipe.AddIngredient(ItemID.SandBlock, 50);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}