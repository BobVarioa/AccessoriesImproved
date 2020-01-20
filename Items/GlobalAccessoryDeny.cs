using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class AnkhShieldDeny : GlobalItem
	{
		public override bool CanEquipAccessory(Item item, Player player, int slot)
		{
			if (item.type == ItemID.AnkhShield)
			{
				if (slot < 10)
				{
					int maxAccessoryIndex = 5 + player.extraAccessorySlots;
					for (int i = 3; i < 3 + maxAccessoryIndex; i++)
					{
						if (slot != i && (player.armor[i].type == ModContent.ItemType<HolyAnkhShield>() || player.armor[i].type == ModContent.ItemType<ShieldOfAnubis>()))
						{
							return false;
						}
					}
				}
			}
			return true;
		}
	}

	public class ManaRegenerationBandDeny : GlobalItem
	{
		public override bool CanEquipAccessory(Item item, Player player, int slot)
		{
			if (item.type == ItemID.ManaRegenerationBand)
			{
				if (slot < 10)
				{
					int maxAccessoryIndex = 5 + player.extraAccessorySlots;
					for (int i = 3; i < 3 + maxAccessoryIndex; i++)
					{
						if (slot != i && (player.armor[i].type == ModContent.ItemType<GreaterManaRegenBand>() || player.armor[i].type == ModContent.ItemType<SuperiorManaRegenBand>() || player.armor[i].type == ModContent.ItemType<EmblemOfMana>()))
						{
							return false;
						}
					}
				}
			}
			return true;
		}
	}

	public class ArcticDivinGearDeny : GlobalItem
	{
		public override bool CanEquipAccessory(Item item, Player player, int slot)
		{
			if (item.type == ItemID.ArcticDivingGear)
			{
				if (slot < 10)
				{
					int maxAccessoryIndex = 5 + player.extraAccessorySlots;
					for (int i = 3; i < 3 + maxAccessoryIndex; i++)
					{
						if (slot != i && (player.armor[i].type == ModContent.ItemType<DesertStormGear>() || player.armor[i].type == ModContent.ItemType<BlizzardDivingGear>() || player.armor[i].type == ModContent.ItemType<InsulatedDivingGear>()))
						{
							return false;
						}
					}
				}
			}
			return true;
		}
	}

	public class FrozenTurtleShellDeny : GlobalItem
	{
		public override bool CanEquipAccessory(Item item, Player player, int slot)
		{
			if (item.type == ItemID.ArcticDivingGear)
			{
				if (slot < 10)
				{
					int maxAccessoryIndex = 5 + player.extraAccessorySlots;
					for (int i = 3; i < 3 + maxAccessoryIndex; i++)
					{
						if (slot != i && (player.armor[i].type == ModContent.ItemType<DesertStormGear>() || player.armor[i].type == ModContent.ItemType<BlizzardDivingGear>() || player.armor[i].type == ModContent.ItemType<SoulOfTheBlizzard>()))
						{
							return false;
						}
					}
				}
			}
			return true;
		}
	}
}