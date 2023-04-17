using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            string appointmentResult = agenda.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = agenda.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
        }
    }
}
