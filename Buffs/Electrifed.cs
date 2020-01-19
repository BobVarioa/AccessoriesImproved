using Terraria;
using Terraria.ModLoader;
using AccessoriesImproved.NPCs;
using Microsoft.Xna.Framework;

namespace AccessoriesImproved.Buffs
{
	public class Electrifed : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Electrifed");
			Description.SetDefault("Electrifed");
			Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.GetGlobalNPC<ElectrifedGlobalNPC>().NPCElectrifed = true;
		}
	}
}