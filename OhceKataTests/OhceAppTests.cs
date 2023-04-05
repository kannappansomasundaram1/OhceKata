using NSubstitute;
using OhceKata;

namespace OhceKataTests;

public class OhceAppTests
{
    private IConsole _console;
    private OhceApp _sut;
    private readonly IGreeter _greeter;
    private readonly IEchoGenerator _echoGenerator;
    private const string _name = "KannaFekoChandu";
    private const string _stopMessage = "Stop!";

    public OhceAppTests()
    {
        _console = Substitute.For<IConsole>();
        _greeter = Substitute.For<IGreeter>();
        _echoGenerator = Substitute.For<IEchoGenerator>();
        _sut = new OhceApp(_console, _greeter, _echoGenerator);
        _console.ReadLine().Returns(_stopMessage);
    }
    
    [Fact]
    public void Greets_With_Name_during_Night()
    {
        var expected = "hi";
        _greeter.GetGreetingMessage(_name).Returns(expected);
        _sut.Start(_name);
        
        _console.Received().WriteLine(expected);
    }
    
    [Fact]
    public void Send_Stop_Message_When_User_Input_Stop()
    {
        _console.ReadLine().Returns(_stopMessage);
        
        _sut.Start(_name);
        
        _console.Received().WriteLine($"Adios {_name}");
    }
    
    [Fact]
    public void Send_Messages_To_Console_From_Echo_Generator()
    {
        const string firstInputTobeEchoed = "hola1";
        const string secondInputTobeEchoed = "hola2";
        _console.ReadLine().Returns(firstInputTobeEchoed, secondInputTobeEchoed, _stopMessage);
        
        _echoGenerator.Echo(firstInputTobeEchoed).Returns(new [] {"echo1"});
        _echoGenerator.Echo(secondInputTobeEchoed).Returns(new [] {"echo2"});
        
        _sut.Start(_name);
        
        _console.Received().WriteLine($"echo1");
        _console.Received().WriteLine($"echo2");
    }
}

