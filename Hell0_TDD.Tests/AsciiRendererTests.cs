using Xunit;
using Hell0_TDD.Core;

namespace Hell0_TDD.Tests;

public class AsciiRendererTests
{
    // First test - easy to assert
    // Checks that the Render method returns a non-empty string.
    [Fact]
    public void Render_ReturnsNonEmptyString_ForSimpleInput()
    {
        // Arrange
        var renderer = new AsciiRenderer();

        // Act
        string result = renderer.Render("Hello");

        // Assert
        Assert.False(string.IsNullOrWhiteSpace(result), "Rendered ASCII should not be empty.");
    }
}
