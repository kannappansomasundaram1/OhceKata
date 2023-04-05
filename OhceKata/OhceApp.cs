namespace  OhceKata;

public class OhceApp
{
    private readonly string _name;
    private readonly IConsole _console;
    private readonly IGreeter _greeter;

    public OhceApp(string name, IConsole console, IGreeter greeter)
    {
        _name = name;
        _console = console;
        _greeter = greeter;
    }

    public void Start()
    {
        var greetingMessage = _greeter.GetGreetingMessage(_name);
        
        _console.WriteLine(greetingMessage);
    }
}
