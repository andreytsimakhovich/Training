using System;
using System.Text;
namespace _51_Lesson
{
    // "Ядерный Ганди" и арифметическое переполнение
    class Program
    {
        static void Main(string[] args)
        {
            byte aggression = 1;

            byte democracyModifier = 2;


            try
            {
                aggression = checked((byte)(aggression - democracyModifier)); //сужающее преобразование данных

                Console.WriteLine(aggression);
            }
            catch (Exception)
            {

                Console.WriteLine("Ошибка: арифметическое переполнение!");
            }

           
        }
    }
}
