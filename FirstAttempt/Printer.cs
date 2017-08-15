using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Printer
    {
        public static void printPersons(List<Person> Persons)
        {
            foreach (var item in Persons)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
                Console.WriteLine($"{item.Address.Street}");
                Console.WriteLine($"{item.Address.Town}, {item.Address.State}, {item.Address.Zipcode}");
                Console.WriteLine($"{item.Address.Country}\n");
            }
        }

        public static void printCompanies(List<Company> Companies)
        {
            foreach (var item in Companies)
            {
                Console.WriteLine($"{item.Name}");
                Console.WriteLine($"{item.Address.Street}");
                Console.WriteLine($"{item.Address.Town}, {item.Address.State}, {item.Address.Zipcode}");
                Console.WriteLine($"{item.Address.Country}\n");
            }
        }
    }
}
