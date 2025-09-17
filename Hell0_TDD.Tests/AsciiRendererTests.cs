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
        string result = _renderer.Render(null);

        Assert.Equal("", result);
    }

    [Fact]
    public void Render_InputIsEmpty_ReturnsEmptyString()
    {
        string result = _renderer.Render("");

        Assert.Equal("", result);
    }

    [Fact]
    public void Render_InputIsWhitespace_ReturnsEmptyString()
    {
        string result = _renderer.Render("   ");

        Assert.Equal("", result);
    }

    [Fact]
    public void Render_SimpleWord_ReturnsSameWord()
    {
        string result = _renderer.Render("Hello");

        Assert.Equal("Hello", result);
    }

    [Fact]
    public void Render_InputHasLeadingAndTrailingSpaces_TrimsInput()
    {
        string result = _renderer.Render("   Hello   ");

        Assert.Equal("Hello", result);
    }

    [Fact]
    public void Render_InputHasMixedCase_PreservesCase()
    {
        string result = _renderer.Render("HeLLo");

        Assert.Equal("HeLLo", result);
    }

    [Fact]
    public void Render_SingleCharacter_ReturnsSameCharacter()
    {
        string result = _renderer.Render("A");

        Assert.Equal("A", result);
    }
}
