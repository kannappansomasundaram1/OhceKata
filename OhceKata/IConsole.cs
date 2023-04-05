namespace OhceKata;

public interface IConsole
{
    void WriteLine(string output);   
}

class Console : IConsole
{
    public void WriteLine(string output)
    {
        System.Console.WriteLine(output);
    }
}