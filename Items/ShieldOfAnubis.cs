using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class ShieldOfAnubis : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Shield of Anubis");
			Tooltip.SetDefault("Grants immunity to knockback and fire blocks \nGrants immunity to most debuffs \nAbsorbs 25% of damage done to players on your team \nOnly active above 25 % life \nGrants a damaging Dash \n 12 % Increase to all damage");
		}

		public override void SetDefaults()
		{
			item.value = Item.buyPrice(0, 10, 0, 0); 
			item.rare = 2;
			item.maxStack = 1;
			item.expert = true;
			item.accessory = true;
			item.defense = 10;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.buffImmune[BuffID.Bleeding] = true;
			player.buffImmune[BuffID.BrokenArmor] = true;
			player.buffImmune[BuffID.Burning] = true;
			player.buffImmune[BuffID.Confused] = true;
			player.buffImmune[BuffID.Cursed] = true;
			player.buffImmune[BuffID.Darkness] = true;
			player.buffImmune[BuffID.Poisoned] = true;
			player.buffImmune[BuffID.Silenced] = true;
			player.buffImmune[BuffID.Slow] = true;
			player.buffImmune[BuffID.Weak] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.hasPaladinShield = true;
			player.allDamageMult += 0.12f;
			player.dash = 2;
			player.noKnockback = true;
		}
		public override bool CanEquipAccessory(Player player, int slot)
		{
			if (slot < 10)
			{
				int maxAccessoryIndex = 5 + player.extraAccessorySlots;
				for (int i = 3; i < 3 + maxAccessoryIndex; i++)
				{
					if (slot != i && (player.armor[i].type == ItemID.AnkhShield || player.armor[i].type == ModContent.ItemType<HolyAnkhShield>()))
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
			recipe.AddIngredient(ModContent.ItemType<HolyAnkhShield>());
			recipe.AddIngredient(ItemID.EoCShield);
			recipe.AddIngredient(ItemID.AvengerEmblem);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}