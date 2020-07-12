using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirMonitor.Models
{
    public class InformationEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }


        public double Value { get; set; }

        public InformationEntity()
        {

        }
    }
}
