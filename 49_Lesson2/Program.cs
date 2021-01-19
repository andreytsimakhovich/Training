using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Lesson2
{
    // Пример, когда удобно использовать рекурсию
    class Program
    {
        class Item
        {
            public int Value { get; set; }

            public Item Child { get; set; }
        }

        static Item InitItem()
        {
            return new Item()
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 10,
                    Child = new Item()
                    {
                    Value = 2
                    }
                }
                
            };
        }

        static void Print (Item item)
        {
            if (item != null)
            {
                Console.WriteLine(item.Value);
                Print(item.Child);
            }
        
        }
        static void Main(string[] args)
        {
            Item item = InitItem();
            Print(item);
        }
    }
}
