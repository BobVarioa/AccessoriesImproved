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
			player.statManaMax2 += 100;
			player.magicDamage += 0.18f;
			player.manaFlower = true;
			player.manaCost += 0.1f;
			player.manaMagnet = true;
		}
		public override bool CanEquipAccessory(Player player, int slot)
		{
			if (slot < 10)
			{
				int maxAccessoryIndex = 5 + player.extraAccessorySlots;
				for (int i = 3; i < 3 + maxAccessoryIndex; i++)
				{
					if (slot != i && (player.armor[i].type == ItemID.ManaRegenerationBand || player.armor[i].type == ModContent.ItemType<SuperiorManaRegenBand>() || player.armor[i].type == ModContent.ItemType<GreaterManaRegenBand>()))
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
			recipe.AddIngredient(ModContent.ItemType<SuperiorManaRegenBand>());
			recipe.AddIngredient(ItemID.CelestialEmblem);
			recipe.AddIngredient(ItemID.FragmentNebula, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}