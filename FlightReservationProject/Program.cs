namespace FlightReservationProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            FlightReservationSystem reservationSystem = new FlightReservationSystem();

            while (true)
            {
                Console.WriteLine("\nFlight Reservation System");
                Console.WriteLine("1. Display Available Flights");
                Console.WriteLine("2. Make a Reservation");
                Console.WriteLine("3. Display Your Bookings");
                Console.WriteLine("4. Exit");

                Console.Write("Select an option (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        reservationSystem.DisplayFlights();
                        break;

                    case "2":
                        Console.Write("Enter Flight Number: ");
                        int flightNumber = int.Parse(Console.ReadLine());

                        Console.Write("Enter Passenger Name: ");
                        string passengerName = Console.ReadLine();

                        reservationSystem.MakeReservation(flightNumber, passengerName);
                        break;

                    case "3":
                        reservationSystem.DisplayBookings();
                        break;

                    case "4":
                        Console.WriteLine("Exiting the Flight Reservation System. Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }
    }
}
