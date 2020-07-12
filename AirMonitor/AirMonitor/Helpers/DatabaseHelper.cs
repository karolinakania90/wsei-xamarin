using AirMonitor.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AirMonitor.Helpers
{
    public static class DatabaseHelper
    {
        public const string DatabaseFilename = "airmonitor.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }

        public static void Setup()
        {
            var db = new SQLiteConnection(DatabasePath);
                
            db.CreateTable<AirQualityIndex>();
            db.CreateTable<MeasurementValue>();
            db.CreateTable<Installation>();
            db.CreateTable<Measurement>();
            db.CreateTable<MeasurementItem>();           
        }

        public static void SaveMeasurement(Measurement measurement)
        {
            var db = new SQLiteConnection(DatabasePath);

            
        }


    }
}
