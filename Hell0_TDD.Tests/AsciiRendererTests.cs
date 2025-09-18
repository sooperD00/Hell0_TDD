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
    public void Render_SimpleWord_ReturnsSameWord()
    {
        string result = _renderer.RenderAscii("Hello");

        Assert.Equal("Hello", result);
    }

    [Fact]
    public void Render_InputHasLeadingAndTrailingSpaces_TrimsInput()
    {
        string result = _renderer.RenderAscii("   Hello   ");

        Assert.Equal("Hello", result);
    }

    [Fact]
    public void Render_InputHasMixedCase_PreservesCase()
    {
        string result = _renderer.RenderAscii("HeLLo");

        Assert.Equal("HeLLo", result);
    }

    [Fact]
    public void Render_SingleCharacter_ReturnsSameCharacter()
    {
        string result = _renderer.RenderAscii("A");

        Assert.Equal("A", result);
    }

    [Fact]
    public void Render_Hi_ReturnsExpectedFiggleOutput()
    {
        // Arrange
        var renderer = new AsciiRenderer();
        string input = "Hi";

        // This is the expected multi-line Figgle ASCII output for "Hi"
        string expectedOutput = "  _   _ _ \r\n | | | (_)\r\n | |_| | |\r\n |  _  | |\r\n |_| |_|_|\r\n          \r\n";

        // Act
        string actualOutput = renderer.RenderAscii(input);

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }
}
