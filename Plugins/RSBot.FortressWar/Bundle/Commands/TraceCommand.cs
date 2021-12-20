using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Objects;
using RSBot.Core.Objects.Spawn;

namespace RSBot.FortressWar.Bundle.Commands
{
    public class TraceCommand:ICommand
    {
        public void Action(string arg, uint senderId)
        {
            SpawnManager.TryGetEntities<SpawnedPlayer>(out var spawnedPlayers);
  
            switch (arg.Length == 0)
            {
                case true:

                    foreach (var spawnedPlayer in spawnedPlayers)
                    {
                        if (spawnedPlayer.UniqueId.Equals(senderId))
                        {
                            doTrace(spawnedPlayer);
                        }
                    }
                    break;
                case false:
                    
                    foreach (var spawnedPlayer in spawnedPlayers)
                    {
                        if (spawnedPlayer.Name.Equals(arg.Trim()))
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
        
    }
}