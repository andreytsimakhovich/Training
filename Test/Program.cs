using System;

namespace Test
{
    class Program
    {

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int result = Sum(10, 15);
         
            Console.Write(result);
        }
    }
}
