using System.Collections.Generic;
using RSBot.Core;

namespace RSBot.FortressWar.Bundle.CommandCore
{
    public class CommandParser
    {
        //parses the command
        public static CommandContainer Parse(string rw, uint senderId)
        {
            
            List<string> split = new List<string>();
            var strings = rw.Split(' '); // split the raw command
            split.AddRange(strings);//add to list

            //set the variables
            var invoke = split[0].Trim(); 
            var command = split[1].Trim();

            // if the command has an arg set it, if not leave it empty
            var arg = "";
            if (split.Count > 2)
            {
                arg = split[2];
            }
            
            
            return new CommandContainer(rw,command,arg,invoke,senderId);
        }
    }
}