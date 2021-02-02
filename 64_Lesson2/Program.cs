using System;

namespace _64_Lesson2
{

    class MyClass
    {
        public MyClass()
        {
            counter++;
        }

        private static int counter;

        public static int Counter
        {
            get { return counter; }
           private set { counter = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            MyClass myClass2 = new MyClass();
            MyClass myClass3 = new MyClass();

            Console.WriteLine(MyClass.Counter);
        }
    }
}
