using System;

namespace _63_Lesson
{

    // Ключевое слово static
    // Статические поля

    class MyClass
    {
        public int a;

        public static int b;
    }
    class Program
    {
        static void Main(string[] args)
        {

            MyClass.b = 5;

            MyClass myClass1 = new MyClass();
            myClass1.a = 44;

            MyClass myClass2 = new MyClass();
            myClass2.a = 22;
            
        }
    }
}
