using System;

namespace _52_Lesson
{
    //Null - совместимые значимые типы (Nullable)
    class Program
    {
        static void Main(string[] args)
        {
            //string str = null; // Это первая часть урока, приводится пример различных типов, которые могут принимать значение null и нет.

            //int a = null;

            //DateTime data = null;

            //Вторая часть урока с примерами.


            int? i = null;

            Console.WriteLine(i == null); // True

            Console.WriteLine(i.HasValue); // False

            Console.WriteLine(i.GetValueOrDefault()); // 0 

            Console.WriteLine(i.GetValueOrDefault(3)); // 3

            Console.WriteLine(i ?? 55); // 55

            Console.WriteLine(); //InvalidOperationExeption
        }
    }
}
