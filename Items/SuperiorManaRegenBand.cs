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
		public override bool CanEquipAccessory(Player player, int slot)
		{
			if (slot < 10)
			{
				int maxAccessoryIndex = 5 + player.extraAccessorySlots;
				for (int i = 3; i < 3 + maxAccessoryIndex; i++)
				{
					if (slot != i && (player.armor[i].type == ItemID.ManaRegenerationBand || player.armor[i].type == ModContent.ItemType<GreaterManaRegenBand>() || player.armor[i].type == ModContent.ItemType<EmblemOfMana>()))
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