using Xunit;
using Hell0_TDD.Core;

namespace Hell0_TDD.Tests;

public class AsciiRendererTests
{
    private readonly AsciiRenderer _renderer;

    public AsciiRendererTests()
    {
        _renderer = new AsciiRenderer();
    }

    // Parameterized tests for various Figgle inputs
    [Theory]
    [InlineData("Hi", "  _   _ _ \r\n | | | (_)\r\n | |_| | |\r\n |  _  | |\r\n |_| |_|_|\r\n          \r\n")]
    [InlineData("   Hi   ", "  _   _ _ \r\n | | | (_)\r\n | |_| | |\r\n |  _  | |\r\n |_| |_|_|\r\n          \r\n")]
    [InlineData("Hello", "  _   _      _ _       \r\n | | | | ___| | | ___  \r\n | |_| |/ _ \\ | |/ _ \\ \r\n |  _  |  __/ | | (_) |\r\n |_| |_|\\___|_|_|\\___/ \r\n                       \r\n")]
    public void RenderAscii_ReturnsExpectedFiggleOutput(string input, string expectedOutput)
    {
        // Act
        string actual = _renderer.RenderAscii(input);

        // Assert
        Assert.Equal(expectedOutput, actual);
    }

    // Keep simple edge-case tests separate
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void RenderAscii_NullOrWhitespaceInput_ReturnsEmptyString(string input)
    {
        string result = _renderer.RenderAscii(input);
        Assert.Equal(string.Empty, result);
    }
}
