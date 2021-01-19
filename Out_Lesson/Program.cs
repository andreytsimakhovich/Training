using System;

namespace Out_Lesson
{
    class Program
    {
        static void Foo(out int value)
        {
            value = 10;
        }
        static void Main(string[] args)
        {
            //int a;
            //Foo(out a);

            Foo(out int a); // можно представлять и в таком виде
        }
    }
}
