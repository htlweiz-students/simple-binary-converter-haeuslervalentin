using BinaryCore;

class Program
{
    public static int Main()
    {
        Console.WriteLine("=== Binary CLI ===");

        List<string> lines = new();

        while(true)
        {
            Console.Write("Gib eine Binärzahl ein: ");
            string? line = Console.ReadLine();

            if(line != "0" && line != "1")
            {
                break;
            }
            lines.Add(line);
        }
        if(lines.Count == 0)
        {
            Console.WriteLine("Fehler: Keine Binärzahlen eingegeben.");
            return 1;
        }
        try
        {
            string input = string.Join("", lines);
            var bits = BinaryParser.Parse(input);
            int result = BinaryConverter.BinaryToDecimal(bits);

            Console.WriteLine($"Dezimalwert: {result}");
            return 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler: {ex.Message}");
            return 2;
        }
    }
}