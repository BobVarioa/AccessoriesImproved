using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class PharaohsPhacemask : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Pharaoh's Phacemask");
			Tooltip.SetDefault("Immune to Desert Winds \nAllows the owner to float for a few seconds \nGrants a togglable slow fall in exchange for your feet \nTogglable Sandstorms ");
		}

		public override void SetDefaults()
		{
			item.value = Item.buyPrice(0, 3, 0, 0);
			item.rare = 5;
			item.maxStack = 1;
			item.expert = false;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.buffImmune[BuffID.WindPushed] = true;
			player.carpet = true;
			player.GetModPlayer<AccessPlayer>().ToggleSandstorm = true;
			player.GetModPlayer<AccessPlayer>().ToggleDjinnsCurse = true;
		}

		public override bool CanEquipAccessory(Player player, int slot)
		{
			if (slot < 10)
			{
				int maxAccessoryIndex = 5 + player.extraAccessorySlots;
				for (int i = 3; i < 3 + maxAccessoryIndex; i++)
				{
					if (slot != i && (player.armor[i].type == ModContent.ItemType<DesertBandana>() || player.armor[i].type == ModContent.ItemType<DesertStormGear>()))
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
			recipe.AddIngredient(ModContent.ItemType<DesertBandana>());
			recipe.AddIngredient(ModContent.ItemType<PharaohsPhabric>(), 3);
			recipe.AddIngredient(ItemID.AncientBattleArmorMaterial, 2);
			recipe.AddIngredient(ItemID.DjinnsCurse);
			recipe.AddIngredient(ItemID.LightShard);
			recipe.AddIngredient(ItemID.DarkShard);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}