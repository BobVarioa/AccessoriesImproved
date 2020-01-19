using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class DestroyerGauntlet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Destroyer Gauntlet");
			Tooltip.SetDefault("Increases melee knockback \n22 % increased melee damage and melee speed \n8 % increased critical strike chance");
		}

		public override void SetDefaults()
		{
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeDamage += 0.22f;
			player.meleeSpeed += 0.22f;
			player.meleeCrit += 8;
			player.GetModPlayer<AccessPlayer>().DestroyerGauntlet = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FireGauntlet);
			recipe.AddIngredient(ItemID.DestroyerEmblem);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}