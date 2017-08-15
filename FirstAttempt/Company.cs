using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Company
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public Company(string Name)
        {
            this.Name = Name;
            this.Address = new Address();
        }
    }
}
