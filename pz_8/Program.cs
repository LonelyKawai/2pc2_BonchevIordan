using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int [12];
            int i;
            Random rnd = new Random();
            for (i = 0; i <= 11; i = i + 1)
             Console.Write($"  {rnd.Next(-12, 12)} ");

            

        }
    }
}
