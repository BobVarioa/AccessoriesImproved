using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class BlizzardDivingGear : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blizzard Diving Gear");
			Tooltip.SetDefault("Applies Electrified to all Attacks \nCan toggle Rain / Blizzards \nPuts a shell around the owner when below 50% life that reduces damage \nGrants the ability to swim and greatly extends underwater breathing \nProvides light under water and extra mobility on ice \nProvides immunity to chill and freezing effects");
		}

		public override void SetDefaults()
		{
			item.value = Item.buyPrice(0, 9, 0, 0);
			item.rare = 8;
			item.maxStack = 1;
			item.expert = false;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<AccessPlayer>().EyeOfTheStorm = true;
			player.GetModPlayer<AccessPlayer>().ToggleRain = true;
			player.GetModPlayer<AccessPlayer>().ToggleSnowstorm = true;
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
			player.AddBuff(62, 5);
		}

		public override bool CanEquipAccessory(Player player, int slot)
		{
			if (slot < 10)
			{
				int maxAccessoryIndex = 5 + player.extraAccessorySlots;
				for (int i = 3; i < 3 + maxAccessoryIndex; i++)
				{
					if (slot != i && (player.armor[i].type == ModContent.ItemType<HeartOfTheStorm>() || player.armor[i].type == ModContent.ItemType<EyeOfTheStorm>() || player.armor[i].type == ModContent.ItemType<SoulOfTheBlizzard>() || player.armor[i].type == ModContent.ItemType<DesertStormGear>() || player.armor[i].type == ModContent.ItemType<InsulatedDivingGear>() || player.armor[i].type == ItemID.ArcticDivingGear || player.armor[i].type == ItemID.FrozenTurtleShell))
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
			recipe.AddIngredient(ModContent.ItemType<SoulOfTheBlizzard>());
			recipe.AddIngredient(ModContent.ItemType<InsulatedDivingGear>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}