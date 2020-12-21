using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int lastNumber;

            uint evenNumbers = 0; // четные числа
            uint oddNumbers = 0; // нечетные числа
            
            int evenNumbersSum = 0; // сумма четных чисел
            int oddNumbersSum = 0; // сумма нечетных чисел
           
                Console.WriteLine("Введите первое число диапазона");
                firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите последнее число диапазона");
                lastNumber = int.Parse(Console.ReadLine());

                while (firstNumber <= lastNumber)
                {
                if (firstNumber % 2 == 0)
                {
                    evenNumbersSum += firstNumber;
                    evenNumbers++;
                }
                else
                {
                    oddNumbersSum += firstNumber;
                    oddNumbers++;
                }
                    firstNumber++;
                }

            Console.WriteLine("Количество четных чисел:\n"+evenNumbers);
            Console.WriteLine("Количество четных чисел:\n"+oddNumbers);
            Console.WriteLine("Сумма четных чисел:\n" + evenNumbersSum);
            Console.WriteLine("Сумма нетных чисел:\n" + oddNumbersSum);
            Console.ReadKey();
        }
    }
}
