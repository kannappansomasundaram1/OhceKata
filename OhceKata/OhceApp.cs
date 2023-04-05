namespace  OhceKata;

public class OhceApp
{
    private readonly IConsole _console;
    private readonly IGreeter _greeter;
    private readonly IEchoGenerator _echoGenerator;

    public OhceApp(IConsole console, IGreeter greeter, IEchoGenerator echoGenerator)
    {
        _console = console;
        _greeter = greeter;
        _echoGenerator = echoGenerator;
    }

    public void Start(string name)
    {
        var greetingMessage = _greeter.GetGreetingMessage(name);
        
        _console.WriteLine(greetingMessage);

        while (true)
        {
            var input = _console.ReadLine();
            if (input == "Stop!")
            {
                _console.WriteLine($"Adios {name}");
                break;
            }

            foreach (var echoeMessages in _echoGenerator.Echo(input))
            {
                _console.WriteLine(echoeMessages);
            }
        }
    }
}
