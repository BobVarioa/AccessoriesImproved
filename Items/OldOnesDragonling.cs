using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class OldOnesDragonling : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Old One's Dragonling");
			Tooltip.SetDefault("+3 Sentry Slots \n25 % increase to minions damage \nApplies Cursed Flame, Fire, and Betsy's Curse to all Attacks \n- 25 Defense");
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
			player.statDefense -= 25;
			player.minionDamage += 0.3f;
			player.maxTurrets += 3;
		}

		public override bool CanEquipAccessory(Player player, int slot)
		{
			if (slot < 10)
			{
				int maxAccessoryIndex = 5 + player.extraAccessorySlots;
				for (int i = 3; i < 3 + maxAccessoryIndex; i++)
				{
					if (slot != i && (player.armor[i].type == ModContent.ItemType<OldOnesAdornment>() || player.armor[i].type == ModContent.ItemType<StardustDragonling>()))
					{
						return false;
					}
				}
			}
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BetsysEgg>());
			recipe.AddIngredient(ModContent.ItemType<OldOnesAdornment>());
			recipe.AddIngredient(ItemID.BetsyWings);
			recipe.AddIngredient(ItemID.BossMaskBetsy);
			recipe.AddTile(TileID.WarTable);
			recipe.AddTile(TileID.WarTableBanner);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}