using System;
using System.Linq;
namespace Null_Lesson
{
    class Program
    {
        // Оператор null-объединения  ??
        // Оператор условного null  ?.

        static int[] GetArray()
        {
            int[] myArray = { 1, 2, 3 }; //null; 
            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetArray();

            Console.WriteLine("Cумма элементов массива: " + (myArray?.Sum() ?? 0));
        }
    }
}
