using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class GreaterManaRegenBand : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Greater Mana Regeneration Band");
			Tooltip.SetDefault("Magic Regeneration Increased \n40 Extra Mana");
		}

		public override void SetDefaults()
		{
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.manaRegenBonus += 30;
			player.statManaMax2 += 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaRegenerationBand);
			recipe.AddIngredient(ItemID.ManaCrystal, 4);
			recipe.AddIngredient(ItemID.ManaRegenerationPotion, 10);
			recipe.AddIngredient(ItemID.MagicPowerPotion, 6);
			recipe.AddIngredient(ItemID.CrystalBall, 2);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}