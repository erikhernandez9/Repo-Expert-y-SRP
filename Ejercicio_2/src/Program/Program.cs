using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Steven Jhonson", "38", "5555-555-555");
            Person doc1 = new Person("Armand", "33", "5435345");
            Doctor d1 = new Doctor(doc1, "Pediatra");

            string appointmentResult = AppointmentService.CreateAppointment("986782342", DateTime.Now, "Wall Street", p1, d1);
            Console.WriteLine(appointmentResult);

            /*string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);*/
        }
    }
}