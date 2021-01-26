using System;

namespace _54_Lesson2
{
    class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = DayOfWeek.Saturday;

            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek))); // получаем тип данных, 

            Console.WriteLine(dayOfWeek);

            Console.WriteLine((int)dayOfWeek); // приводим DayOfWeek к int 

            Console.WriteLine((DayOfWeek)4); // приводим int к DayOfWeek;

            DayOfWeek nextDay = GetNextDay (dayOfWeek);
            Console.WriteLine(nextDay);



            static DayOfWeek GetNextDay(DayOfWeek day)
            {
                if (day < DayOfWeek.Sunday)
                    return day + 1;

                return DayOfWeek.Monday;
            }
        }
    }
}
