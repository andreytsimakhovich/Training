using System;

namespace IN_Lesson
{
    class Program
    {
        static void Foo(in int a)
        {

        }
        static void Main(string[] args)
        {
            int a = 5;

            Foo(a);
        }
    }
}
