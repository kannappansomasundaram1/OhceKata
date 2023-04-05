namespace OhceKata;

public interface IGreeter
{
    string GetGreetingMessage(string name);
}

public class Greeter : IGreeter
{
    private readonly IDateTime _dateTime;

    public Greeter(IDateTime dateTime)
    {
        _dateTime = dateTime;
    }

    public string GetGreetingMessage(string name)
    {
        var currentTime = _dateTime.Now();
        var greeting = currentTime switch 
        {
            {Hour: >= 6 and < 12 } => "¡Buenos días",
            {Hour: >= 12 and < 20 } => "¡Buenas tardes",
            {Hour: >= 20 or < 6} => "¡Buenas noches",
        };
        return $"{greeting} {name}!";
    }
}