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
            Log.Notify(arg.Length);
            switch (arg.Length)
            {
                case 0:
                    foreach (var spawnedPlayer in spawnedPlayers)
                    {
                        if (spawnedPlayer.UniqueId == senderId)
                        {
                            doTrace(spawnedPlayer);
                        }
                    }
                    break;
                default:
                    foreach (var spawnedPlayer in spawnedPlayers)
                    {
                        if (spawnedPlayer.Name.Equals(arg))
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