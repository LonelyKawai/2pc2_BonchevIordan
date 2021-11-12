using System;

using System.Text.RegularExpressions;

namespace pz_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = Regex.Split(input, @"\D+");           
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    int i = int.Parse(value);
                    if (i == -9)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == -8)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == -7)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == -6)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == -5)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == -4)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == -3)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == -2)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == -1)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == 0)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == 9)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == 8)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == 7)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == 6)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == 5)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == 4)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == 3)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine("я вывожу только числа, не цифры!");
                    }
                    else
                    {
                        Console.WriteLine(" {0}", i);
                    }
                        
                 }
            }
        }
    }
}
