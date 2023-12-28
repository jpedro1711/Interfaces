using Interfaces.Entities;
using System;
using System.Globalization;
using Interfaces.Services;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();

            Console.WriteLine("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        
            Vehicle vehicle = new Vehicle(model);

            CarRental rental = new CarRental(start, finish, vehicle);

            Console.WriteLine("Enter price per hour:");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per day:");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            BrazilTaxService brazilTaxService = new BrazilTaxService(); 

            RentalService rentalService = new RentalService(hour, day, brazilTaxService);

            rentalService.ProcessInvoice(rental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(rental.Invoice);
        }
    }
}
