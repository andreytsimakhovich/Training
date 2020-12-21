using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("\nВы ввели число 1");
                    break;

                case 2:
                    Console.WriteLine("\nВы ввели число 2");
                    break;

                default:
                    Console.WriteLine("\nВы ввели неверные данные");
                    break;
            }
        }
    }
}
