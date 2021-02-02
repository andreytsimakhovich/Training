using System;

namespace _62_Lesson
{
    // Свойства (Properties)
    // Автоматические свойства

    class Point
    {
        private int x;

        public void SetX(int x)
        {
            if (x<1)
            {
                this.x = 1;
                return;
            }

            if (x>5)
            {
                this.x = 5;
                return;
            }

            this.x = x;
        }

        public int GetX()
        {
            return x;
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Z { get; set; } // Автоматичсекое свойство - сокращенное
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.SetX(2);

            Console.WriteLine(point.GetX());

            point.Y = 10;
            int y = point.Y;
            Console.WriteLine(y);

            point.Z = 8;
            int z = point.Z;
            Console.WriteLine(z);
        }
    }
}
