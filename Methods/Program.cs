﻿using System;

namespace Methods
{
    class Program
    {
        static int Sum(int a, int b)
        {
            int result = a + b;

            return result;
        }

        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);

            Console.WriteLine(c);

            Console.WriteLine("бла бла бла");

            c = Sum(a, b);

            Console.WriteLine(c);
        }
    }
}
