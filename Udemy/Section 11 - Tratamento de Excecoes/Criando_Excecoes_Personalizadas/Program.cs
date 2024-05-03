using Criando_Excecoes_Personalizadas.Entities;
using Criando_Excecoes_Personalizadas.Entities.Exceptions;

namespace Criando_Excecoes_Personalizadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reservation reservation;

            int number;
            DateTime checkIn;
            DateTime checkOut;

            try
            {
                Console.Write("Room number: ");
                number = int.Parse(Console.ReadLine());

                Console.Write("Check-in-date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out-date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");

                Console.Write("Check-in-date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out-date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }
}
