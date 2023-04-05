using NSubstitute;
using OhceKata;

namespace OhceKataTests;

public class OhceAppTests
{
    private IConsole _console;
    private OhceApp _sut;
    private readonly IGreeter _greeter;

    public OhceAppTests()
    {
        _console = Substitute.For<IConsole>();
        _greeter = Substitute.For<IGreeter>();
        _sut = new OhceApp("KannaFekoChandu", _console, _greeter);
    }
    
    [Fact]
    public void Greets_With_Name_during_Night()
    {
        var expected = "hi";
        _greeter.GetGreetingMessage("KannaFekoChandu").Returns(expected);
        _sut.Start();
        
        _console.Received().WriteLine(expected);
    }
}