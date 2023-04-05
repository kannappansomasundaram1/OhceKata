namespace OhceKata;

internal class Console : IConsole
{
    public void WriteLine(string output)
    {
        System.Console.WriteLine(output);
    }

    public string ReadLine()
    {
        return System.Console.ReadLine();
    }
}