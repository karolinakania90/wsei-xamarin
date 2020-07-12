

namespace AirMonitor.Models
{
    public class Installation
    {
        public int Id { get; set; }

        public Location Location { get; set; }


        public int LocationFkKey { get; set; }

        public Address Address { get; set; }


        public Installation()
        {

        }

        public Installation(string city, string street, string number)
        {
            this.Address = new Address(city, street, number);
        }
    }
}
