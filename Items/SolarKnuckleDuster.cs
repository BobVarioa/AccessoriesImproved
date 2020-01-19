using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class SolarKnuckleDuster : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Solar Knuckle Duster");
			Tooltip.SetDefault("Increases melee knockback \n26 % increased melee damage and melee speed \n10 % increased critical strike chance");
		}

		public override void SetDefaults()
		{
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeDamage += 0.26f;
			player.meleeSpeed += 0.26f;
			player.meleeCrit += 10;
			player.GetModPlayer<AccessPlayer>().DestroyerGauntlet = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<DestroyerGauntlet>());
			recipe.AddIngredient(ItemID.FragmentSolar, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}