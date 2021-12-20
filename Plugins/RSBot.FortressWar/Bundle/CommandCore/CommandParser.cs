using System.Collections.Generic;
using RSBot.Core;

namespace RSBot.FortressWar.Bundle.CommandCore
{
    public class CommandParser
    {
        public static CommandContainer Parse(string rw, uint senderId)
        {
            Log.Notify(rw);
            
            List<string> split = new List<string>();
            var strings = rw.Split(' ');
            split.AddRange(strings);

            var invoke = split[0].Trim();
            var command = split[1].Trim();

            var arg = "";
            if (split.Count > 2)
            {
                arg = split[2];
                Log.Notify("Displaying arg "+arg);
            }
            
            Log.Notify("Displaying invoke "+invoke);
            Log.Notify("Displaying command "+command);
            
            return new CommandContainer(rw,command,arg,invoke,senderId);
        }
    }
}