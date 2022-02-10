using System;

namespace pz_3_create_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Address house1 = new Address("Germany", "munhen", "agoi", 43, 2);
            Address house2 = new Address("Usa", "london", "jdfhg", 44, 1);
            Address house3 = new Address("Russia", "moscow", "gjkdfhkg", 45, 3);
            Address house4 = new Address("Bulgaria", "plowdiv", "fgjhdjkg", 46, 5);
            house1.GetAddress();
            house2.GetAddress();
            house3.GetAddress();
            house4.GetAddress();
        }
    }
}
