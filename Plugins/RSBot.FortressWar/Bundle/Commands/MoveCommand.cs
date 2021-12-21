using System.Linq;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Objects.Spawn;
using RSBot.FortressWar.Bundle.CommandCore;

namespace RSBot.FortressWar.Bundle.Commands
{
    public class MoveCommand:ICommand
    {
        public void Action(string arg, uint senderId)
        {
            SpawnManager.TryGetEntities<SpawnedPlayer>(out var spawnedPlayers);
            var players = spawnedPlayers.ToList();
            
            switch (arg.Length == 0)
            {
                case true:
                    foreach (var spawnedPlayer in players)
                    {
                        if (spawnedPlayer.UniqueId.Equals(senderId) && CheckPower.BySenderId(senderId))
                            Game.Player.FastMove(spawnedPlayer.Tracker.Position);
                    }
                    break;
                
                case false:
                    foreach (var spawnedPlayer in players)
                    {
                        if (spawnedPlayer.Name.Equals(arg) && CheckPower.BySenderId(senderId))
                            Game.Player.FastMove(spawnedPlayer.Tracker.Position);
                    }
                    break;
                
            }
            
        }

        public string Description()
        {
            return "Moves the player to the postion of the command giver";
        }
    }
}