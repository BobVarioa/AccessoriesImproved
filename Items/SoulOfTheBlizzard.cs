using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class SoulOfTheBlizzard : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul of the Blizzard");
			Tooltip.SetDefault("Applies Electrified to all Attacks \nCan toggle Rain / Blizzards \nPuts a shell around the owner when below 50% life that reduces damage");
		}

		public override void SetDefaults()
		{
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<AccessPlayer>().EyeOfTheStorm = true;
			player.GetModPlayer<AccessPlayer>().ToggleRain = true;
			player.GetModPlayer<AccessPlayer>().ToggleSnowstorm = true;
			player.AddBuff(62, 5);
		}

		public override bool CanEquipAccessory(Player player, int slot)
		{
			if (slot < 10)
			{
				int maxAccessoryIndex = 5 + player.extraAccessorySlots;
				for (int i = 3; i < 3 + maxAccessoryIndex; i++)
				{
					if (slot != i && (player.armor[i].type == ModContent.ItemType<HeartOfTheStorm>() || player.armor[i].type == ModContent.ItemType<EyeOfTheStorm>() || player.armor[i].type == ModContent.ItemType<BlizzardDivingGear>() || player.armor[i].type == ItemID.FrozenTurtleShell || player.armor[i].type == ModContent.ItemType<DesertStormGear>()))
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
			recipe.AddIngredient(ModContent.ItemType<HeartOfTheStorm>());
			recipe.AddIngredient(ModContent.ItemType<EyeOfTheStorm>());
			recipe.AddIngredient(ItemID.FrozenTurtleShell);
			recipe.AddIngredient(ItemID.FrostCore, 2);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}