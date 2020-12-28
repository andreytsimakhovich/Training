using System;

namespace Method_hw1
{
    class Program
    {
        static void PrintLine (string symbol, uint multiplier)
        {
            for (int i = 0; i < multiplier; i++)
            {
                Console.Write(symbol + "\t");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение множителя: ");
            uint multiplier = uint.Parse(Console.ReadLine());

            Console.WriteLine("Введите символ: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("Результат:");

            PrintLine(symbol, multiplier);

            Console.ReadKey();
        }
    }
}
