using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine("первое задание");
            for (int i = 0; i <= 60; i += 5)
            {
                Console.WriteLine();
            }
            Console.WriteLine("второе задание");
            for (int j = 6; j < 5; j++) 
            {
                Console.WriteLine(letters [j]);
            }
            Console.WriteLine();

            Console.WriteLine("третье задание");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("###");
            }
            Console.WriteLine();

            Console.WriteLine("четвертое задание");
            for (int j = 0; j <= 100; j++)
            {
                if (j % 5 == 0)
                {
                    Console.WriteLine(j + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("пятое задание");
            for (int i = 2, j = 40; i - j != 20; i++, j--)
            {
                Console.WriteLine(i + " " + j);
            }
        }
    }
}
