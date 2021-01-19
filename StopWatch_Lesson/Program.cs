using System;
using System.Diagnostics;

namespace StopWatch_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }

            sw.Stop();

            Console.WriteLine($"Time spent: {sw.ElapsedMilliseconds}");

            Console.ReadLine();
        }
    }
}
