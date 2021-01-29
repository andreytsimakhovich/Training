using System;

namespace _60_Lesson
{
    class Program
    {

        class Point
        {
            public Point()
            {

            }

            public Point(int x, int y)
            {
                _x = x;
                _y = y;
            }

            private int _x;
            private int _y;

            public  void Print()
            {
                Console.WriteLine($"X: {_x} |  Y: {_y}");
            }
        }

        
        static void Main(string[] args)
        {
            Point point = new Point();
            point.Print();
        }
    }
}
