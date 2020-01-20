using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class InsulatedDivingGear : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Insulated Diving Gear");
			Tooltip.SetDefault("Grants the ability to swim and greatly extends underwater breathing \nProvides light under water and extra mobility on ice \nProvides immunity to chill and freezing effects");
		}

		public override void SetDefaults()
		{
			item.value = Item.buyPrice(0, 7, 10, 0);
			item.rare = 7;
			item.maxStack = 1;
			item.expert = false;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.buffImmune[BuffID.Frozen] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.arcticDivingGear = true;
			player.accFlipper = true;
			player.accDivingHelm = true;
			player.iceSkate = true;
			if (player.wet)
			{
				Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 0.9f, 0.2f, 0.6f);
			}
		}

		public override bool CanEquipAccessory(Player player, int slot)
		{
			if (slot < 10)
			{
				int maxAccessoryIndex = 5 + player.extraAccessorySlots;
				for (int i = 3; i < 3 + maxAccessoryIndex; i++)
				{
					if (slot != i && (player.armor[i].type == ModContent.ItemType<DesertStormGear>() || player.armor[i].type == ModContent.ItemType<BlizzardDivingGear>() || player.armor[i].type == ItemID.ArcticDivingGear))
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
			recipe.AddIngredient(ItemID.HandWarmer);
			recipe.AddIngredient(ItemID.ArcticDivingGear);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}