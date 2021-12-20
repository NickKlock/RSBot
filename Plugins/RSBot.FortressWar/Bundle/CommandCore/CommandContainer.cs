namespace RSBot.FortressWar.Bundle.CommandCore
{
    public class CommandContainer
    {
	    private string _raw;
        private string _command;
	    private string _arg;
	    private string _invoke;
	    private uint _senderId;
        	
	    public CommandContainer(string rw, string command, string arg, string invoke, uint senderId)
        	{
        		_raw = rw;
        		_command = command;
        		_arg = arg;
                _invoke = invoke;
                _senderId = senderId;
            }

	    public string Raw
	    {
		    get => _raw;
		    set => _raw = value;
	    }

	    public string Command
	    {
		    get => _command;
		    set => _command = value;
	    }

	    public string Arg
	    {
		    get => _arg;
		    set => _arg = value;
	    }

	    public string Invoke
	    {
		    get => _invoke;
		    set => _invoke = value;
	    }

	    public uint SenderId
	    {
		    get => _senderId;
		    set => _senderId = value;
	    }
    }
}