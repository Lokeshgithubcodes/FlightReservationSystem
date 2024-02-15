using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationProject
{
    public class FlightReservationSystem
    {
        private List<Flight> flights;
        private List<Booking> bookings;

        public FlightReservationSystem()
        {
            
            flights = new List<Flight>
        {
            new Flight { FlightNumber = 1, Origin = "CityA", Destination = "CityB",  TotalSeats = 50, AvailableSeats = 50 },
            new Flight { FlightNumber = 2, Origin = "CityB", Destination = "CityC", TotalSeats = 40, AvailableSeats = 40 },
            new Flight { FlightNumber = 3, Origin = "CityC", Destination = "CityD", TotalSeats = 30, AvailableSeats = 30 }
        };

            bookings = new List<Booking>();
        }

        public void DisplayFlights()
        {
            Console.WriteLine("Available Flights:");
            foreach (var flight in flights)
            {
                Console.WriteLine($"Flight {flight.FlightNumber} - {flight.Origin} to {flight.Destination}, Available Seats: {flight.AvailableSeats}/{flight.TotalSeats}");
            }
        }

        public void MakeReservation(int flightNumber, string passengerName)
        {
            var selectedFlight = flights.FirstOrDefault(flight => flight.FlightNumber == flightNumber);

            if (selectedFlight != null && selectedFlight.AvailableSeats > 0)
            {
                var booking = new Booking { BookingId = bookings.Count + 1, FlightNumber = flightNumber, PassengerName = passengerName };
                bookings.Add(booking);

                selectedFlight.AvailableSeats--;
                Console.WriteLine($"Reservation successful! Booking ID: {booking.BookingId}");
            }
            else
            {
                Console.WriteLine("Invalid flight or no available seats.");
            }
        }

        public void DisplayBookings()
        {
            Console.WriteLine("Your Bookings:");
            foreach (var booking in bookings)
            {
                var flight = flights.FirstOrDefault(f => f.FlightNumber == booking.FlightNumber);
                Console.WriteLine($"Booking ID: {booking.BookingId}, Flight: {flight.Origin} to {flight.Destination}, Passenger: {booking.PassengerName}");
            }
        }
    }
}
