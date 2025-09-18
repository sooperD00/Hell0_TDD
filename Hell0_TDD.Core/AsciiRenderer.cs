using Figgle;
using Figgle.Fonts;

namespace Hell0_TDD.Core;

public class AsciiRenderer
{
    // Cache the standard font once since it never changes
    private static readonly FiggleFont StandardFont = FiggleFonts.Standard;

    public static string RenderAscii(string input)
    {
        // Guard against null, empty, or whitespace input
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        // Trim input but preserve case (ASCII art is case-sensitive)
        string cleanInput = input.Trim();

        // Render the ASCII art using the standard Figgle font
        return StandardFont.Render(cleanInput);
    }
}
