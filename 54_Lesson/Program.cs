﻿using System;
using System.Collections.Generic;

namespace _54_Lesson
{
    // enum (перечисления)
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                
                int keyCode = (int)key;

                Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Вы нажали enter!");
                }
            }

        }
    }
}
