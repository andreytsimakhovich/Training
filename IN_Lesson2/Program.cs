using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;

namespace IN_Lesson2
{
    class Program
    {

        struct Point
        {
            public float x;
            public float y;
            public float z;
        }

        static void Foo(Point value)
        {

        }

        static void Bar(in Point value)
        {

        }
        static void Main(string[] args)
        {
            Point a = new Point();

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Foo(a);
            }

            sw.Stop();
            Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");

            sw.Restart();

            sw.Start();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Bar(a);
            }

            sw.Stop();
            Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");
        }
    }
}
