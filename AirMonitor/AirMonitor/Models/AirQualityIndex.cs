﻿using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AirMonitor.Models
{
    public class AirQualityIndex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
        public string Advice { get; set; }
        public string Color { get; set; }

        public AirQualityIndex()
        {

        }
    }
}