using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Lesson_Task1
{
    class Program
    {
        static void PrintArray(int[] arr, int i = 0)
        {
            
            if (i < arr.Length)
            {
                Console.WriteLine(arr[i]);
                PrintArray(arr, i + 1);
            }
               

        }
        static void Main(string[] args)
        {
            int[] myArray= { 1, 2, 3, 5, 10, 100, 200};
           
            PrintArray(myArray);

        }
    }
}
