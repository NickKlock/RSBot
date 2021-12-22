using System.Linq;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Objects.Spawn;
using RSBot.FortressWar.Bundle.CommandCore;

namespace RSBot.FortressWar.Bundle.Commands
{
    public class StructureCommand:ICommand
    {
        public void Action(string arg, uint senderId)
        {
            SpawnManager.TryGetEntities<SpawnedFortressStructure>(out var spawnedFortressStructures);
            
            foreach (var spawnedFortressStructure in spawnedFortressStructures)
            {
                if (spawnedFortressStructure.Record.GetRealName().ToLower().Contains("gate") ||
                    spawnedFortressStructure.Record.GetRealName().ToLower().Contains("heart") ||
                    spawnedFortressStructure.Record.GetRealName().ToLower().Contains("tower") && CheckPower.BySenderId(senderId))
                {
                    if (spawnedFortressStructure.Record.GetRealName().ToLower().Contains("heart"))
                    {
                        EquipGlavieTwohand();
                    }
                    Game.Player.SelectEntity(spawnedFortressStructure.UniqueId);
                    SkillManager.CastAutoAttack(spawnedFortressStructure.UniqueId);
                }
            }
        }

        private void EquipGlavieTwohand()
        {
            var inventoryItems = Game.Player.Inventory.Items;
            foreach (var inventoryItem in inventoryItems)
            {                        
                Log.Notify(inventoryItem.Record.CodeName);
                if (inventoryItem.Record.CodeName.ToLower().Contains("tsword") ||
                    inventoryItem.Record.CodeName.ToLower().Contains("glavie"))
                {
                    inventoryItem.Equip(6);
                    return;
                }
            }
        }
        public string Description()
        {
            return "Attacks FW structures and equips on Glavie or Two-handed sword";
        }
        
    }
}