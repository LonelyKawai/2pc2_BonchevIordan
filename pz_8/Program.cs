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
                A[i] = rnd.Next(-12, 12);
            foreach (int j in A)
            {
                Console.Write(j + " ");
            }
            A = OneStepRight(A);
            A = OneStepRight(A);
            A = OneStepRight(A);
            A = OneStepRight(A);
            Console.WriteLine();
            foreach (int j in A)
            {
                Console.Write(j + " ");
            }


        }
        public static int[] OneStepRight(int[] Arr)
        {

            int temp2 = 0;
            int temp3 = 0;
            int temp1 = Arr[Arr.Length - 1];
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                if (i > 0)
                {
                    if (i % 2 != 0)
                    {
                        temp3 = Arr[i + 1];
                        Arr[i + 1] = temp2;
                    }
                    else
                    {
                        temp2 = Arr[i + 1];
                        Arr[i + 1] = temp3;
                    }
                }
                else
                {
                    temp2 = Arr[1];
                    Arr[i + 1] = Arr[i];
                }

            }
            Arr[0] = temp1;
            return Arr;
        }
    }
}
