﻿using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите высоту треугольника: ");
            //int height = int.Parse(Console.ReadLine());

            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();



            Console.Write("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}
