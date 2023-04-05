using FluentAssertions;
using OhceKata;

namespace OhceKataTests;

public class EchoGeneratorTests
{
    [Theory]
    [InlineData("hola", "aloh")]
    [InlineData("stop", "pots")]
    public void Returns_Echo_Of_The_Input(string input, string expected)
    {
        var sut = new EchoGenerator();

        var result = sut.Echo(input);

        result.Should().BeEquivalentTo(expected);
    }
    
    [Theory]
    [InlineData("oto")]
    [InlineData("madam")]
    public void Returns_Echo_Of_The_Input_Along_With_Palindrome_Message_When_Input_Is_A_Palindrome(string expected)
    {
        var sut = new EchoGenerator();

        var result = sut.Echo(expected);

        result.Should().BeEquivalentTo(expected, "¡Bonita palabra!");
    }
}