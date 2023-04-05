using FluentAssertions;
using NSubstitute;
using OhceKata;

namespace OhceKataTests;

public class GreeterTests
{
    private readonly IDateTime _dateTime;
    private readonly Greeter _sut;
    private readonly string _name;

    public GreeterTests()
    {
        _name = "KannaFekoChandu";
        _dateTime = Substitute.For<IDateTime>();
        _sut = new Greeter(_dateTime);
    }

    [Theory]
    [InlineData("20:00:01", "¡Buenas noches KannaFekoChandu!")]
    [InlineData("10:00:01", "¡Buenos días KannaFekoChandu!")]
    [InlineData("16:00:01", "¡Buenas tardes KannaFekoChandu!")]
    [InlineData("04:00:01", "¡Buenas noches KannaFekoChandu!")]
    public void Greets_With_Greeting_Message_Based_On_Time_Of_The_Day(string timeString, string expected)
    {
        var time = TimeOnly.Parse(timeString);
        _dateTime.Now().Returns(time);
        
        var result = _sut.GetGreetingMessage(_name);

        result.Should().Be(expected);
    }
}