using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiTripToAddress
{


    class Address
    {

        public string Street { get; set; }
        public int number { get; set; }
        public string zip { get; set; }
        public string City { get; set; }

        public Address(string Street, int number, string zip, string city)
        {
            this.Street = Street;
            this.number = number;
            this.zip = zip;
            this.City = city;
        }
    }
}
