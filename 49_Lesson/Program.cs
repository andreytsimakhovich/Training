using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


namespace _49_Lesson
{
    /*
         * Рекурсия
         * 
         * Методы и стек
         * 
         * Переполнение стека
         */


    class Program
    {

        static void Foo(int i)
        {
            Console.WriteLine(i);
            if (i >= 3)
                return;

            i++;
            Foo(i);
        }
     
        static void Main(string[] args)
        {
            Foo(0);
        }
    }
}
