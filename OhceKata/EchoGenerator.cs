namespace OhceKata;

public class EchoGenerator : IEchoGenerator
{
    public IReadOnlyCollection<string> Echo(string input)
    {
        var result = new List<string>();
        var echo = string.Concat(input.Reverse());
        result.Add(echo);
        if(echo == input)
            result.Add("¡Bonita palabra!");
        return result.ToArray();
    }
}