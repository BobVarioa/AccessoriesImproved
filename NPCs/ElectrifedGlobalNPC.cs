using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved.NPCs
{
	public class ElectrifedGlobalNPC : GlobalNPC
	{
		public override bool InstancePerEntity => true;

		public bool NPCElectrifed;

		public override void ResetEffects(NPC npc)
		{
			NPCElectrifed = false;
		}

		public override void UpdateLifeRegen(NPC npc, ref int damage)
		{
			if (NPCElectrifed)
			{
				if (npc.lifeRegen > 0)
				{
					npc.lifeRegen = 0;
				}
				npc.lifeRegen -= 32;
			}
		}
	}
}
