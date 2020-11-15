using System;

namespace kolokwium
{

    class Program
    {
        public static void Mechanizm()
        {
            int suma;
            string czas;
            czas = Console.ReadLine();
                
            
        }
        public static void Tablica()
        {
            int[,] tab = new int[4, 10];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tab[i, j] = (1);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(tab[i, j]); ;
                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tablica();
        }


    }
}
