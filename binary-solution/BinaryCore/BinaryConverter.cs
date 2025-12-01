namespace BinaryCore;

public static class BinaryConverter
{
    public static int BinaryToDecimal(bool[] bits)
    {
        int value = 0;

        foreach (var bit in bits)
        {
            value = (value << 1) + (bit ? 1 : 0);
        }

        return value;
    }

    public static string DecimalToBinary(int number)
    {
        if (number < 0)
            throw new ArgumentException("Number must be >= 0");

        return Convert.ToString(number, 2);
    }
}