using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AccessoriesImproved
{
    public class StatBook : ModItem
    {
        public int inum = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stat Book");
        }

        public override void SetDefaults()
        {
            item.value = Item.buyPrice(0, 0, 0, 0);
            item.rare = 0;
            item.maxStack = 1;
        }


        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            Player player = Main.player[item.owner];

            TooltipLine[] lines = new TooltipLine[1000];
            
            // Health / Defense
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Max Life: {player.statLifeMax2} HP"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Life Regen: {player.lifeRegen} HP/second"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Defense: {player.statDefense}"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Damage Reduction: {player.endurance * 100}%"); inum++;

            // Melee
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Melee Damage: {player.meleeDamage * 100}%"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Melee Speed: {player.meleeSpeed * 100}%"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Melee Crit: {player.meleeCrit}%"); inum++;

            // Ranged
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Ranged Damage: {player.rangedDamage * 100}%"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Ranged Crit: {player.rangedCrit}%"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Stealth: {-player.stealth}"); inum++;

            // Magic
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Magic Damage: {player.magicDamage * 100}%"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Magic Crit: {player.magicCrit}%"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Max Mana: {player.statManaMax2} MP"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Mana Regen: {player.manaRegen} MP/second"); inum++;

            // Summon
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Summon Damage: {player.minionDamage * 100}%"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Max Minions: {player.maxMinions}"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Max Sentries: {player.maxTurrets}"); inum++;

            // Throwing
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Throwing Damage: {player.thrownDamage * 100}%"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Throwing Crit: {player.thrownCrit}%"); inum++;

            // Speed
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Max Speed: {(player.accRunSpeed + player.maxRunSpeed) / 2f * player.moveSpeed * 6} mph"); inum++;
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Wing Time: {player.wingTimeMax / 60} seconds"); inum++;

            // Misc
            lines[inum] = new TooltipLine(mod, (inum + 1).ToString(), $"Aggro: {player.aggro}"); inum++;

            Array.Resize(ref lines, inum);

            for (int i = 0; i < lines.Length; i++)
            {
                tooltips.Add(lines[i]);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Sign);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}