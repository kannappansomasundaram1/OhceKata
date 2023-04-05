namespace OhceKata;

public interface IEchoGenerator
{
    IReadOnlyCollection<string> Echo(string input);
}