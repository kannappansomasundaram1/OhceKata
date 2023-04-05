namespace  OhceKata;

public class OhceApp
{
    private readonly string _name;
    private readonly IConsole _console;
    private readonly IGreeter _greeter;
    private readonly IEchoGenerator _echoGenerator;

    public OhceApp(string name, IConsole console, IGreeter greeter, IEchoGenerator echoGenerator)
    {
        _name = name;
        _console = console;
        _greeter = greeter;
        _echoGenerator = echoGenerator;
    }

    public void Start()
    {
        var greetingMessage = _greeter.GetGreetingMessage(_name);
        
        _console.WriteLine(greetingMessage);

        while (true)
        {
            var input = _console.ReadLine();
            if (input == "Stop!")
            {
                _console.WriteLine($"Adios {_name}");
                break;
            }

            foreach (var echoeMessages in _echoGenerator.Echo(input))
            {
                _console.WriteLine(echoeMessages);
            }
        }

    }
}
