using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person John = new Person("John", "Doe");
            Person Jane = new Person("Jane", "Doe");

            List<Person> Persons = new List<Person>();
            Persons.Add(John);
            Persons.Add(Jane);

            Company Acme = new Company("Acme, Inc.");
            Company Warner = new Company("Warner Bros.");

            List<Company> Companies = new List<Company>();
            Companies.Add(Acme);
            Companies.Add(Warner);

            Printer.printPersons(Persons);
            Printer.printCompanies(Companies);
        }
    }
}
