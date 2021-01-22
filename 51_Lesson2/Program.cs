using System;

namespace _51_Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;

            Console.WriteLine("Введите значение");
            int c = int.Parse(Console.ReadLine()); 

            a = checked (a + c); //переполнение через верхнюю границу
            Console.WriteLine(a);

            int b = int.MinValue;
            b = b - 1; //переполнение через нижнюю границу
            Console.WriteLine(b);
        }
    }
}
