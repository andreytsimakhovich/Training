using System;

namespace _48_Lesson
{
    /*
     * Именованные параметры
     */

    class Program
    {
        static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;

            if (enableLogging)
            {
                Console.WriteLine("Значение переменной a = " + a);
                Console.WriteLine("Значение переменной b = " + b);
                Console.WriteLine("Результат сложения = " + result);
            }

            return result;
        }
        static void Main(string[] args)
        {

            // 1 вариант  
            //Sum(b: 2, a: 10);   // Конкретно указывается имя параметра и его значение. Порядок не важен.

            // 2 вариант 
            int firstValue = 5;
            int secondValue = 2;
            int result = Sum(firstValue, secondValue, enableLogging:true);
        }
    }
}
