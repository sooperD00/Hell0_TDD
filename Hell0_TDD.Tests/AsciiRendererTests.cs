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

    [Fact]
    public void Render_InputIsNull_ReturnsEmptyString()
    {
        string result = _renderer.RenderAscii(null);

        Assert.Equal("", result);
    }

    [Fact]
    public void Render_InputIsEmpty_ReturnsEmptyString()
    {
        string result = _renderer.RenderAscii("");

        Assert.Equal("", result);
    }

    [Fact]
    public void Render_InputIsWhitespace_ReturnsEmptyString()
    {
        string result = _renderer.RenderAscii("   ");

        Assert.Equal("", result);
    }

    [Fact]
    public void Render_InputHasLeadingAndTrailingSpaces_TrimsInput()
    {
        string result = _renderer.RenderAscii("   Hi   ");

        Assert.Equal("Hello", result);
    }

    [Fact]
    public void Render_Hi_ReturnsExpectedFiggleOutput()
    {
        // Arrange
        string input = "Hi";

        // This is the expected multi-line Figgle ASCII output for "Hi"
        string expectedOutput = "  _   _ _ \r\n | | | (_)\r\n | |_| | |\r\n |  _  | |\r\n |_| |_|_|\r\n          \r\n";

        // Act
        string actualOutput = _renderer.RenderAscii(input);

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }
}
