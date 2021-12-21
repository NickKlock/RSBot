using RSBot.Core;

namespace RSBot.FortressWar.Bundle.CommandCore
{
    public static class CommandHandler
    {
        //handles the command gets called when the bot receives the package from the server
        public static void HandleCommand(CommandContainer commandContainer)
        {
            if (Views.View.Instance.Commands.ContainsKey(commandContainer.Command))
            {
                Views.View.Instance.Commands[commandContainer.Command].Action(commandContainer.Arg,commandContainer.SenderId);
            }
        }
    }
}