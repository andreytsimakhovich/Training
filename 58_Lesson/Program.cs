using System;

namespace _58_Lesson
{
    // Инкапсуляция
    class Program
    {

        class Gun
        {
            private bool isLoaded;
            private void Reload()
            {
                Console.WriteLine("Заряжаю...");

                isLoaded = true;

                Console.WriteLine("Заряжено!");
            }

            public void Shoot()
            {
                if (!isLoaded)
                {
                    Console.WriteLine("Орудие не заряжено!");
                    Reload();
                }

                Console.WriteLine("Ба-бах!\n");
                isLoaded = false;
            }
        }
        static void Main(string[] args)
        {
            Gun gun = new Gun();

            // gun.isLoaded = true;
            gun.Shoot();
        }
    }
}
