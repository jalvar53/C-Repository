using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Address
    {
        public string Town { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public  string Country { get; set; }

        public Address()
        {
            this.Town = "Sometown";
            this.Street = "123 Main Street";
            this.State = "OH";
            this.Zipcode = "12345";
            this.Country = "United States";
        }
    }
}
