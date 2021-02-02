﻿using System;

namespace _64_Lesson
{
    // Ключевое слово static    

    // Статические методы класса

    // Статические свойства класса

    class MyClass
    {
        private static int a;

        private int b;

        public static void Foo()
        {
            Console.WriteLine($"Вызван метод Foo!");
            a = 5;
            Console.WriteLine(a);
        }

        public void Bar()
        {
            Console.WriteLine("Вызван метод Bar!");
            Console.WriteLine(a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Bar();
            MyClass.Foo();

        }
    }
}
