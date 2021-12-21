using System.Linq;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Objects;
using RSBot.Core.Objects.Spawn;
using RSBot.FortressWar.Bundle.CommandCore;
using RSBot.FortressWar.Views;

namespace RSBot.FortressWar.Bundle.Commands
{
    public class TraceCommand:ICommand
    {
        public void Action(string arg, uint senderId)
        {
            SpawnManager.TryGetEntities<SpawnedPlayer>(out var spawnedPlayers);

            // switch on arg length, if 0 the sender is the person to trace
            //if not the person with the name in arg is the person to be traced
            switch (arg.Length == 0)
            {
                case true:

                    foreach (var spawnedPlayer in spawnedPlayers)
                    {            

                        if (spawnedPlayer.UniqueId.Equals(senderId) && CheckPower.BySenderId(senderId))
                        {
                            doTrace(spawnedPlayer);
                        }
                    }
                    
                    break;
                case false:
                    
                    foreach (var spawnedPlayer in spawnedPlayers)
                    {
                        if (spawnedPlayer.Name.Equals(arg.Trim()) && CheckPower.BySenderId(senderId))
                        {
                            doTrace(spawnedPlayer);
                        }
                    }
                    break;
            }
            

        }

        private void doTrace(SpawnedPlayer player)
        {
            Game.Player.StartTrace(player.UniqueId);
        }
        
        public string Description()
        {
            return "Traces the command giving person or the person in the argument.";
        }
        
    }
}