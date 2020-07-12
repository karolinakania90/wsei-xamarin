
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace AirMonitor.Models
{
    public class Installation
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [OneToOne]
        public Location Location { get; set; }

        [OneToOne]
        public Address Address { get; set; }

        public Installation()
        {

        }
    }
}
