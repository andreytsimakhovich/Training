using System;

namespace Tuple_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = (5, 7, 10);
            Console.WriteLine(values.Item1);

            values.Item2 += 10;
            Console.WriteLine(values.Item2);

            Console.ReadKey();
        }
    }
}
