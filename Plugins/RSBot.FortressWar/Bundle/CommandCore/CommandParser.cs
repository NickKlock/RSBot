using System.Collections.Generic;

namespace RSBot.FortressWar.Bundle.CommandCore
{
    public class CommandParser
    {
        public static CommandContainer Parse(string rw, uint senderId)
        {
            List<string> split = new List<string>();
            var strings = rw.Split(' ');
            split.AddRange(strings);

            var invoke = split[0].Trim();
            var command = split[1].Trim();
            var arg = split[2].Trim();
            return new CommandContainer(rw,command,arg,invoke,senderId);
        }
    }
}