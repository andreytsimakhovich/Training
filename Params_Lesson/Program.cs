using System;

namespace Params_Lesson
{
    class Program
    {
        static int Sum(params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            int result = Sum(5, 10, 11, 24);
            Console.WriteLine(result);
        }
    }
}
