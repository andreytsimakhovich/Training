using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace _55_Lesson
{
    // ООП
    // класс
    // объект класса

    enum Color
    {
        Red,
        Green,
        Orange,
        Yellow,
        Blue
    }

    class Point
    {
        public int x;
        public int y;
        public Color color;
    }

    class Program
    {
        static void Main(string[] args)
        {

            Point p = new Point();

            
            p.x = 4;
            p.y = 2;
            p.color = Color.Orange;

            Console.WriteLine($"X: {p.x} | Y: {p.y} | Color: {p.color}");
          
        }
    }
}
