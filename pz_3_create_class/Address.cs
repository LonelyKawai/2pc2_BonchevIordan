using System;
using System.Collections.Generic;
using System.Text;

namespace pz_3_create_class
{
    class Address
    {
        public string country;
        public string city;
        public string street;
        public int house;
        public int flat;
        public Address(string a, string b, string c, int d, int e)
        {
            country = a;
            city = b;
            street = c;
            house = d;
            flat = e;
        }
        public void GetAddress()
        {
            Console.WriteLine($"country = {country}, city = {city}, street = {street}, house = {house}, flat = {flat}");
        }


    }

}

