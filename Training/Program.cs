using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            Console.WriteLine("Выбери + или - :");
            string selection = Console.ReadLine();

            int c = selection == "+" ? (a + b) : (a - b);
            Console.WriteLine(c);

        }
    }
}
