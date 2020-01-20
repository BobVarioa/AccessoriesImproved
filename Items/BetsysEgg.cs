using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class BetsysEgg : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Betsy's Egg");
			Tooltip.SetDefault("Applies Cursed Flame, Fire, and Betsy's Curse to all Attacks \n- 35 Defense");
		}

		public override void SetDefaults()
		{
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.rare = 2;
			item.maxStack = 1;
			item.expert = true;
			item.accessory = true;
			item.expert = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<AccessPlayer>().BetsyEgg = true;
			player.statDefense -= 35;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<EternalFlame>());
			recipe.AddIngredient(ItemID.DD2PetDragon);
			recipe.AddIngredient(ItemID.ApprenticeStaffT3);
			recipe.AddTile(TileID.WarTable);
			recipe.AddTile(TileID.WarTableBanner);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}