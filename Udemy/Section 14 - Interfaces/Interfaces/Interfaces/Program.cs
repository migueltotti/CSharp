using Interfaces.Entitites;
using Interfaces.Services;
using System.Globalization;


namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarRental carRental;

            // car data
            string model;

            // data rent:
            DateTime start;
            DateTime finish;

            // price data
            double hour;
            double day;

            Console.WriteLine("Enter rental data: ");
            Console.Write("Car model: ");
            model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalservice = new RentalService(hour, day, new BrazilTaxService());

            rentalservice.ProcessingInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
