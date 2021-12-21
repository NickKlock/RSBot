namespace RSBot.FortressWar.Bundle.CommandCore
{
    public class CommandContainer
    {
	    //
	    //Command container with all the info for the command 
	    // getter and setters
	    //
	    
	    private string _raw; // raw text
        private string _command; // 2nd word
	    private string _arg;// 3rd word
	    private string _invoke;// current invoke cmd
	    private uint _senderId;// sender Player UniqueID
        	
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