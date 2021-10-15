using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int size = 7;
            int[,] B = new int[size, size];
            int[] C = new int[size];
            int sumC = 0;
   
            Random rnd = new Random();
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    B[i, j] = rnd.Next(-10, 10);
                    Console.Write($" A[ {i},{j} ] = {B[i, j]}\t");
                }
                Console.WriteLine(); ;
            }
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        C[i] = B[i, j]; sumC = sumC + C[i];
                    }
                }
            }
            Console.WriteLine("Элементы главной диагонали:");
            int count = 0;
            for (i = 0, j = 0; i < size; i++, j++)
            {
                if (B[i, j] >= 0) count++;
                Console.Write(B[i, j] + " " );
            }
            Console.WriteLine("\nКоличество положительных элементов " + count);
        }
    }
}
