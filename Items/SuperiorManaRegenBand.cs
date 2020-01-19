using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class SuperiorManaRegenBand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Superior Mana Regeneration Band");
			Tooltip.SetDefault("Magic Regeneration Increased \n60 Extra Mana");
		}

		public override void SetDefaults()
		{
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.manaRegenBonus += 35;
			player.statManaMax2 += 60;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<GreaterManaRegenBand>());
			recipe.AddIngredient(ItemID.SorcererEmblem);
			recipe.AddIngredient(ItemID.SuperManaPotion, 15);
			recipe.AddIngredient(ItemID.MagicPowerPotion, 10);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}