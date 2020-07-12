using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AirMonitor.Models
{
    public class Measurement
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int CurrentDisplayValue { get; set; }

        [OneToMany]
        public MeasurementItem Current { get; set; }

        [OneToMany]
        public Installation Installation { get; set; }
    }
}