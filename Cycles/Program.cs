using System;

// Добавление пространств имен

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {

            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Одномерный массив<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            //int[] myArray = { 10, 3, 2, 55}; n     

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]); 
            //}
            //Console.ReadLine();

            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Заполнить массив с клавиатуры<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            //Console.Write("Введите количество элементов массива:\t");

            //int elementsCount = int.Parse(Console.ReadLine());

            //int[] myArray = new int[elementsCount];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write($"\nВведите элемент массива под индексом {i}: \t");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nВывод массива:");

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);

            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Вывод массива в обратном порядке<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            //int [] myArray = new int [] { 12, 34, 54, 23, 123 };

            //for (int i = myArray.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //Console.ReadLine();

            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Выыод массива в обратном порядке с вводом с клавиатуры<<<<<<<<<<<<<<<<<<<<<<<<<

            //Console.Write("Введите количество элементов массива:\t");

            //int elementsCount = int.Parse(Console.ReadLine());

            //int[] myArray = new int[elementsCount];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write($"\nВведите элемент массива под индексом {i}: \t");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nВывод массива:");
            //for (int i = myArray.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //Console.ReadLine();

            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Найти сумму четных чисел в массиве<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            //int[] myArray = {2, 10, 15, 17, 3, 21, 6, 81, 100, 120};
            //int sum = 0;

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);

            //    if (myArray[i]%2 == 0)
            //    {
            //        sum += myArray[i];
            //    }
            //}
            //Console.WriteLine("\nВывод суммы: "+sum);
            //Console.ReadLine();

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Найти наименьшее число в массиве<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            //int[] myArray = { 2, 4, 6, 1 };
            //int minValue = myArray[0];

            //for (int i = 1; i < myArray.Length; i++)       // i = 1 так как мы обращаемся к [0] элементу массива
            //{
            //    Console.WriteLine(myArray[i]);

            //    if (minValue > myArray[i])
            //    {
            //        minValue = myArray[i];
            //    }
            //}
            //Console.WriteLine(minValue);
            //Console.ReadLine();

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Как рабоать с массивами в C# на самом деле<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            int [] myArray = {111,10,4,99,49,64,77,4,42,5};

            // min max элемент массива

            //int result = myArray.Max();
            //int result = myArray.Min(); 
            //Console.WriteLine(result);

            //Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());     // сумма всех четных элементов массивов

            int [] result = Array.FindAll(myArray, i => i < 70);

            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
