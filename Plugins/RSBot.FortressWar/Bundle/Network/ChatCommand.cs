using FortressWar.Views;
using RSBot.Chat.Objects;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Network;
using RSBot.Core.Objects.Spawn;
using RSBot.FortressWar.Bundle.CommandCore;
using RSBot.FortressWar.Views;

namespace RSBot.FortressWar.Bundle.Network
{
    internal class ChatCommand : IPacketHandler
    {
        public ushort Opcode => 0x3026;

        public PacketDestination Destination => PacketDestination.Client;
        public void Invoke(Packet packet)
        {
            var type = (ChatType)packet.ReadByte();

            if (type == ChatType.All)
            {
                var senderId = packet.ReadUInt();
                var messageAll = packet.ReadString();

                if (messageAll.StartsWith("cmd"))
                {
                    Log.Notify("Handling Command");
                    CommandHandler.HandleCommand(CommandParser.Parse(messageAll, senderId));
                }
            }
            

        }
    }
}