using System;
using System.IO;

namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\Users\User\Desktop\f1.txt", FileMode.Open, FileMode.ReadWrite);
            // подчеркивает красным а я не понимаю почему (@"C:\Users\User\Desktop\f1.txt") (FileMode.Open) (ReadWrite)
            StreamReader reader = new StreamReader(file);
            string[] str = reader.ReadToEnd().Split("\n");
            reader.Close();
            int a = 0;
            for(int i = 0; i < file.Length; i++)
            {
                if(str[i].Length > a)
                {
                    a = i; 
                }
                Console.WriteLine(str[a]);
            }
        }
    }
}
