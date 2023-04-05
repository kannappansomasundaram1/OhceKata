namespace OhceKata;

public interface IDateTime
{
    TimeOnly Now();
}

public class DateTimeProvider : IDateTime
{
    public TimeOnly Now()
    {
        return TimeOnly.FromDateTime(DateTime.Now);
    }
}