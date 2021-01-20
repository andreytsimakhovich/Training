using System;

namespace _49_Lesson_Task2
    
    // Сумма массива
{
    class Program
    {
        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return 0;
            int result = Sum(myArray, i + 1);

            return myArray[i] + result;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 5, 10, 15 };
          
            int result = Sum(myArray);

            Console.WriteLine(result);
        }   
    }
}
