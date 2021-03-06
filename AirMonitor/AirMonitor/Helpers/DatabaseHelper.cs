﻿using AirMonitor.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.IO;

namespace AirMonitor.Helpers
{
    public static class DatabaseHelper
    {
        public const string DatabaseFilename = "airmonitor.db3";

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
            using (var db = new SQLiteConnection(DatabasePath))
            {
                db.CreateTable<InformationEntity>();
            }
        }

        public static void Update(List<Measurement> items)
        {         
            using (var db = new SQLiteConnection(DatabasePath))
            {
                db.DeleteAll<InformationEntity>();

                foreach (var item in items)
                {
                    var entry = new InformationEntity();

                    entry.Street = item.Installation.Address.Street;

                    entry.City = item.Installation.Address.City;

                    entry.StreetNumber = item.Installation.Address.Number;

                    entry.Value = item.CurrentDisplayValue;

                    db.Insert(entry);
                }
            }
        }

        public static List<InformationEntity> GetAll()
        {
            using (var db = new SQLiteConnection(DatabasePath))
            {
                return db.GetAllWithChildren<InformationEntity>();
            }
        }
    }
}
