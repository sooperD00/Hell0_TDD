using Xunit;
using Hell0_TDD.Core;

namespace Hell0_TDD.Tests;

public class AsciiRendererTests
{

    // Null, empty, or whitespace input
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData("\t")]
    [InlineData("\n")]
    public void RenderAscii_NullOrWhitespaceInput_ReturnsEmptyString(string input)
    {
        string result = AsciiRenderer.RenderAscii(input);
        Assert.Equal(string.Empty, result);
    }

    // Leading/trailing whitespace is trimmed
    [Theory]
    [InlineData("   Hi   ", "  _   _ _ \r\n | | | (_)\r\n | |_| | |\r\n |  _  | |\r\n |_| |_|_|\r\n          \r\n")]
    [InlineData("\tHello\t", "  _   _      _ _       \r\n | | | | ___| | | ___  \r\n | |_| |/ _ \\ | |/ _ \\ \r\n |  _  |  __/ | | (_) |\r\n |_| |_|\\___|_|_|\\___/ \r\n                       \r\n")]
    public void RenderAscii_TrimmedInput_ReturnsExpectedOutput(string input, string expectedOutput)
    {
        string actual = AsciiRenderer.RenderAscii(input);
        Assert.Equal(expectedOutput, actual);
    }

    // Special characters and numbers
    [Theory]
    [InlineData("!@#", "  _   ____    _  _   \r\n | | / __ \\ _| || |_ \r\n | |/ / _` |_  ..  _|\r\n |_| | (_| |_      _|\r\n (_)\\ \\__,_| |_||_|  \r\n     \\____/          \r\n")]
    [InlineData("123", "  _ ____  _____ \r\n / |___ \\|___ / \r\n | | __) | |_ \\ \r\n | |/ __/ ___) |\r\n |_|_____|____/ \r\n                \r\n")]
    public void RenderAscii_SpecialCharactersAndNumbers_ReturnsExpectedOutput(string input, string expectedOutput)
    {
        string actual = AsciiRenderer.RenderAscii(input);
        Assert.Equal(expectedOutput, actual);
    }

    // Consistency: same input returns identical output
    [Fact]
    public void RenderAscii_SameInputMultipleTimes_ReturnsSameOutput()
    {
        string input = "Hi";
        string first = AsciiRenderer.RenderAscii(input);
        string second = AsciiRenderer.RenderAscii(input);

        Assert.Equal(first, second);
    }

    // Very long input (does not throw)
    [Fact]
    public void RenderAscii_VeryLongInput_DoesNotThrow()
    {
        string longInput = new string('A', 1000);
        var exception = Record.Exception(() => AsciiRenderer.RenderAscii(longInput));
        Assert.Null(exception);
    }
}
