using System;
using System.Text;

namespace _50_Lesson
{
    // Преобразование и приведение примитивных типов в С#
    class Program
    {
        static void Foo(float value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            double a = 5.3;
            Foo((float)a);
           
        }
    }
}
 