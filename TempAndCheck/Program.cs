namespace TempAndCheck;

internal static class Program
{
    private static void TemperaturaReport()
    {
        Console.WriteLine("\nВведите значения температур (Для выхода введите \"stop\")!");
        List<int> temperatura = new List<int>();
        string s;
        int i = 0;
        int parser;
        while (string.Compare((s = Console.ReadLine()), "stop") != 0)
        {
            int.TryParse(s, out parser);
            temperatura.Add(parser);
            ++i;
        }

        foreach (var VARIABLE in temperatura)
        {
            if (VARIABLE < 0)
            {
                Console.Write("(-)");
                Console.Write($"{-VARIABLE}\n");
            }
            else if(VARIABLE > 0)
            {
                Console.Write("(+)");
                Console.Write($"{VARIABLE}\n");
            }
            else
            {
                Console.Write($"{VARIABLE}\n");
            }
        }
    }

    private static void DataChecking()
    {
        int temp;
        do
        {
            Console.WriteLine("\nВведете целое число");
        } while (!int.TryParse(Console.ReadLine(), out temp));
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a method!:\n" +
                          "type \"1\" for temperature report\n" +
                          "type \"2\" for data checking!");
        var choice = Console.ReadKey();
        if(choice.Key == ConsoleKey.D1)
            TemperaturaReport();
        else if(choice.Key == ConsoleKey.D2)
            DataChecking();
        else 
            Console.Error.WriteLine("\nОшибка!");
    }
}