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
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.buffImmune[BuffID.WindPushed] = true;
			player.carpet = true;
			player.GetModPlayer<AccessPlayer>().ToggleSandstorm = true;
			player.GetModPlayer<AccessPlayer>().ToggleDjinnsCurse = true;
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