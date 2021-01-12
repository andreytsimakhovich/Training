using System;

namespace Enum_Lesson
{

    enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6, 
        Sunday = 7
    }
    class Program
    {
        static void Main(string[] args)
        {
            Days d;
            d = Days.Thursday;
            Console.WriteLine((int)d);      // тип перечисления обязательно должен представлять целочисленный тип (byte, int, short, long)

            d = Days.Monday;
            Console.WriteLine(d);     

            Console.ReadKey();
        }
    }
}
