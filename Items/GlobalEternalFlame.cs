using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.Items
{
	public class GlobalEternalFlame : GlobalItem
	{
		public override void OpenVanillaBag(string context, Player player, int arg)
		{
			if (arg == ItemID.BossBagBetsy) {
				if (context == "bossBag") {
					player.QuickSpawnItem(ModContent.ItemType<EternalFlame>(), 1);
				}
			}
		}
	}
}