using RSBot.Core;

namespace RSBot.FortressWar.Bundle.CommandCore
{
    public static class CommandHandler
    {
        //handles the command gets called when the bot receives the package from the server
        public static void HandleCommand(CommandContainer commandContainer)
        {
            var useCommands = PlayerConfig.Get<bool>("RSBot.FortressWar.UseChatCommands");
            if (Views.View.Instance.Commands.ContainsKey(commandContainer.Command) && useCommands)
            {
                Views.View.Instance.Commands[commandContainer.Command].Action(commandContainer.Arg,commandContainer.SenderId);
            }
        }
    }
}