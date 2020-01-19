using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class EmblemOfMana : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Emblem of Mana");
			Tooltip.SetDefault("Magic Regeneration Increased \n100 Extra Mana \nIncreases pickup range for mana stars \n18% increased magic damage \n10 % reduced mana usage \nAutomatically use mana potions when needed");
		}

		public override void SetDefaults()
		{
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.manaRegenBonus += 40;
			player.statManaMax2 += 60;
			player.magicDamage += 0.18f;
			player.manaFlower = true;
			player.manaCost += 0.1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SuperiorManaRegenBand>());
			recipe.AddIngredient(ItemID.CelestialEmblem);
			recipe.AddIngredient(ItemID.FragmentNebula, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}