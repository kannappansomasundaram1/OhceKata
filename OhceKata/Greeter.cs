namespace OhceKata;

public interface IGreeter
{
    string GetGreetingMessage();
}

public class Greeter : IGreeter
{
    private readonly IDateTime _dateTime;

    public Greeter(IDateTime dateTime)
    {
        _dateTime = dateTime;
    }

    public string GetGreetingMessage()
    {
        var currentTime = _dateTime.Now();
        return currentTime switch 
        {
            {Hour: >= 6 and < 12 } => "¡Buenos días",
            {Hour: >= 12 and < 20 } => "¡Buenas tardes",
            {Hour: >= 20 or < 6} => "¡Buenas noches",
            //> new TimeOnly(20,0,0) => 
        };
    }
}