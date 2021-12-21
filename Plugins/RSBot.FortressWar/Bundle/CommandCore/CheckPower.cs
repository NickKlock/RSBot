using System.Linq;
using RSBot.Core.Components;
using RSBot.Core.Objects.Spawn;
using RSBot.Views;

namespace RSBot.FortressWar.Bundle.CommandCore
{
    public class CheckPower
    {

        public static bool BySenderId(uint senderId)
        {
            SpawnManager.TryGetEntities<SpawnedPlayer>(out var spawnedPlayers);
            var players = spawnedPlayers.ToList();
            var player = players.Where(playerUid => playerUid.UniqueId == senderId);

           
            var hasPower = player.Any();
            return  hasPower;
        }
        
    }
}