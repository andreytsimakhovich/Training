using System;

using System.Reflection;

namespace _57_Lesson
{
    // модификаторы доступа public и private, для членов класса
    class Point 
    {
        int z = 5;

        public int x = 1;

        private int y = 44;

        private void PrintX()
        {
            Console.WriteLine($"X: {x}");
        }

        public void PrintY()
        {
            Console.WriteLine($"Y: {y}");
        }

        public void PrintPoint()
        {
            PrintY();
            PrintX();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            var typeInfo = typeof(Point).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var item in typeInfo)
            {
                Console.WriteLine($"{item.Name}\t IsPrivate: {item.IsPrivate}\t IsPublic: {item.IsPublic}");
            }

        }
    }
}
