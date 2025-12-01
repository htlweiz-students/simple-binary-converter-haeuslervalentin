namespace BinaryCore;

public static class BinaryParser
{
    public static bool[] Parse(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException("Input cannot be empty.");

        return input
            .Where(c => c == '0' || c == '1')
            .Select(c => c == '1')
            .ToArray();
    }
}