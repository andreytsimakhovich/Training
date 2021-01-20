using System;

namespace _49_Lesson_Task3
{
    // Найти сумму цифр числа с помощью рекурсии   561=12 
    class Program
    {
        static int Foo(int value)
        {
            if (value < 10)
                return value;

            int lastDigit = value % 10;

            int cutValue = value / 10;

            return lastDigit + Foo(cutValue);
        }
        static void Main(string[] args)
        {
            int myValue = 561;

            int result = Foo(myValue);

            Console.WriteLine(result);
        }   
    }
}
