using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class EternalFlame : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Eternal Flame");
			Tooltip.SetDefault("Applies Cursed Flame and Fire to all Attacks");
		}

		public override void SetDefaults()
		{
			item.value = Item.buyPrice(0, 4, 0, 0);
			item.rare = 2;
			item.maxStack = 1;
			item.accessory = true;
			item.expert = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<AccessPlayer>().EternalFlame = true;
		}

		
	}
}