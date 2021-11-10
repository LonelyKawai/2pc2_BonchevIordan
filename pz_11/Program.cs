using System;
using System.Text.RegularExpressions;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            int res = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (i == 0)
                {
                    if (charArray[0] == '_' | Regex.IsMatch(charArray[0].ToString(), @"[a-zA-Z\d]"))
                    {
                        res += 1;
                    }
                }
                else
                {
                    if (Regex.IsMatch(charArray[i].ToString(), @"[a-zA-Z\d]"))
                    {
                        res += 1;
                    }
                }
            }

            if (res == charArray.Length)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
