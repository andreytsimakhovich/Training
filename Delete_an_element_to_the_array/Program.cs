using System;

namespace Delete_an_element_to_the_array
{
    class Program
    {
        static void RemoveAt (ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i-1] = array[i];
            }

            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6, 2 };

            RemoveAt(ref myArray, 3);
        }
    }
}
