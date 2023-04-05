using System.Diagnostics;

namespace  OhceKata;

public class OhceApp
{
    private readonly string _name;
    private readonly IConsole _console;
    private readonly Greeter _greeter;

    public OhceApp(string name, IConsole console, IDateTime dateTime)
    {
        _name = name;
        _console = console;
        _greeter = new Greeter(dateTime);
    }

    public void Start()
    {
        var buenasNoches = _greeter.GetGreetingMessage();
        
        _console.WriteLine($"{buenasNoches} {_name}!");
    }
}
