using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("введите число N");
            int b = int.Parse(Console.ReadLine());
            int a, v;
            a = 1;
            while (a < b)
            {
                a *= 2;
                if (a > b)
                    break;
                Console.WriteLine(a);
            }
        }
    }
}
