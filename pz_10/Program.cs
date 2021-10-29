using System;
using System.Linq;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] myArray0 = new int[20];
            int[][] myArray = new int[8][];
            myArray[0] = new int[rnd.Next(6, 10)];
            myArray[1] = new int[rnd.Next(6, 10)];
            myArray[2] = new int[rnd.Next(6, 10)];
            myArray[3] = new int[rnd.Next(6, 10)];
            myArray[4] = new int[rnd.Next(6, 10)];
            myArray[5] = new int[rnd.Next(6, 10)];
            myArray[6] = new int[rnd.Next(6, 10)];
            myArray[7] = new int[rnd.Next(6, 10)];

            
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new int[rnd.Next(6, 10)];
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = (int)rnd.Next(1024);
                    Console.Write("\t" + myArray[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            myArray0[3] = myArray[0][myArray[0].Length - 1];
            myArray0[4] = myArray[1][myArray[1].Length - 1];
            myArray0[5] = myArray[2][myArray[2].Length - 1];
            myArray0[6] = myArray[3][myArray[3].Length - 1];
            myArray0[7] = myArray[4][myArray[4].Length - 1];
            myArray0[8] = myArray[5][myArray[5].Length - 1];
            myArray0[9] = myArray[6][myArray[6].Length - 1];
            myArray0[10] = myArray[7][myArray[7].Length - 1];
            Console.WriteLine(" " + myArray0[3] +' '+ myArray0[4] +' '+ myArray0[5] +' '+ myArray0[6] +' '+ myArray0[7] +' '+ myArray0[8] +' '+ myArray0[9] +' '+ myArray0[10]);
            
            myArray0[3] = myArray[0].Max();
            myArray0[4] = myArray[1].Max(); 
            myArray0[5] = myArray[2].Max(); 
            myArray0[6] = myArray[3].Max(); 
            myArray0[7] = myArray[4].Max();
            myArray0[8] = myArray[5].Max();
            myArray0[9] = myArray[6].Max();
            myArray0[10] = myArray[7].Max();
            Console.WriteLine(" " + myArray0[3] + ' ' + myArray0[4] + ' ' + myArray0[5] + ' ' + myArray0[6] + ' ' + myArray0[7] + ' ' + myArray0[8] + ' ' + myArray0[9] + ' ' + myArray0[10]);
            



        }
    }
}
