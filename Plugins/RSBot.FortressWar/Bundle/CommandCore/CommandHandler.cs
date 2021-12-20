using RSBot.Core;

namespace RSBot.FortressWar.Bundle.CommandCore
{
    public class CommandHandler
    {
        public static void HandleCommand(CommandContainer commandContainer)
        {
            if (Views.View.Instance.Commands.ContainsKey(commandContainer.Command))
            {
                Views.View.Instance.Commands[commandContainer.Command].Action(commandContainer.Arg,commandContainer.SenderId);
            }
        }
    }
}