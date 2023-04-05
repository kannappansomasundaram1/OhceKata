using NSubstitute;
using OhceKata;

namespace OhceKataTests;

public class OhceAppTests
{
    private IConsole _console;
    private IDateTime _dateTime;
    private string _name;
    private OhceApp _sut;

    public OhceAppTests()
    {
        _name = "KannaFekoChandu";
        _console = Substitute.For<IConsole>();
        _dateTime = Substitute.For<IDateTime>();
        _sut = new OhceApp(_name, _console, _dateTime);
    }
    
    [Fact]
    public void Greets_With_Name_during_Night()
    {
        _dateTime.Now().Returns(new TimeOnly(20,00,01));

        _sut.Start();
        
        _console.Received().WriteLine($"¡Buenas noches {_name}!");
    }
    
    [Fact]
    public void Greets_With_Name_during_Day()
    {
        _dateTime.Now().Returns(new TimeOnly(10,00,01));
        
        _sut.Start();
        
        _console.Received().WriteLine($"¡Buenos días {_name}!");
    }
    
    [Fact]
    public void Greets_With_Name_during_Afternoon()
    {
        _dateTime.Now().Returns(new TimeOnly(16,00,01));
        
        _sut.Start();
        
        _console.Received().WriteLine($"¡Buenas tardes {_name}!");
    }
    
    [Fact]
    public void Greets_With_Name_during_EarlyMonring()
    {
        _dateTime.Now().Returns(new TimeOnly(04,00,01));
        
        _sut.Start();
        
        _console.Received().WriteLine($"¡Buenas noches {_name}!");
    }
}