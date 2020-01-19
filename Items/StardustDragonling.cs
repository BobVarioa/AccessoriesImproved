using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class StardustDragonling : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Stardust Dragonling");
			Tooltip.SetDefault("+3 Sentry Slots \n+2 Minion Slots \n30 % increase to minions damage \nApplies Cursed Flame, Fire, and Betsy's Curse to all Attacks \n- 20 Defense");
		}

		public override void SetDefaults()
		{
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.expert = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<AccessPlayer>().BetsyEgg = true;
			player.statDefense -= 20;
			player.minionDamage += 0.3f;
			player.maxTurrets += 3;
			player.maxMinions += 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<OldOnesDragonling>());
			recipe.AddIngredient(ItemID.FragmentStardust, 15);
			recipe.AddTile(TileID.WarTable);
			recipe.AddTile(TileID.WarTableBanner);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}