using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class OldOnesAdornment : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Old One's Adornment");
			Tooltip.SetDefault("+3 Sentry Slots \n25 % increase to minions damage");
		}

		public override void SetDefaults()
		{
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.minionDamage += 0.25f;
			player.maxTurrets += 3;
		}

		public override bool CanEquipAccessory(Player player, int slot)
		{
			if (slot < 10)
			{
				int maxAccessoryIndex = 5 + player.extraAccessorySlots;
				for (int i = 3; i < 3 + maxAccessoryIndex; i++)
				{
					if (slot != i && (player.armor[i].type == ModContent.ItemType<StardustDragonling>() || player.armor[i].type == ModContent.ItemType<OldOnesDragonling>()))
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
			recipe.AddIngredient(ItemID.ApprenticeScarf);
			recipe.AddIngredient(ItemID.MonkBelt);
			recipe.AddIngredient(ItemID.HuntressBuckler);
			recipe.AddIngredient(ItemID.SquireShield);
			recipe.AddTile(TileID.WarTable);
			recipe.AddTile(TileID.WarTableBanner);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}