using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AirMonitor.Models
{
    public class Address
    {
 
        public Address(string city, string street, string number)
        {
            this.City = city;
            this.Street = street;
            this.Number = number;
        }

        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string DisplayAddress1 { get; set; }
        public string DisplayAddress2 { get; set; }

        public string Description => $"{Street} {Number}, {City}";
    }
}
