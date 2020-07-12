using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AirMonitor.Models
{
    public class MeasurementItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public DateTime FromDateTime { get; set; }

        [OneToMany]
        public MeasurementValue[] Values { get; set; }

        [OneToMany]
        public AirQualityIndex[] Indexes { get; set; }
    }
}