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
                        Console.Write(" {0}", i);
                    }
            }
        }
    }
}
