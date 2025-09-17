namespace Hell0_TDD.Core;

public class AsciiRenderer
{
    public string Render(string input)
    {
        // Handle null, empty, or whitespace input
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        // Trim leading/trailing spaces, preserve case
        return input.Trim();
    }
}
