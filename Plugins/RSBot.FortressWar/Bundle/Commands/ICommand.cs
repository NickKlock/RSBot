namespace RSBot.FortressWar.Bundle.Commands
{
    public interface ICommand
    {
        //interface for commands
        void Action(string arg, uint senderId);
        string Description();
    }
}