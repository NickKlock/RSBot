namespace RSBot.FortressWar.Bundle.Commands
{
    public interface ICommand
    {
        void Action(string arg, uint senderId);
    }
}