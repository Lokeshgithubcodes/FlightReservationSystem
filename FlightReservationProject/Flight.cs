using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationProject
{
    public class Flight
    {
        public int FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
       
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
    }
}
