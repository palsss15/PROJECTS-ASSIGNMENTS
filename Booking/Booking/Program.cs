using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Booking
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nChecking The Date and Time availability...");

            Boolean val = AppointmentTests.HasPassed(new TakeDateTime().appointDateTime());

            if (val == true)
            {
                Console.WriteLine("\nThis Date and Time is not available,enter another time.");
                AppointmentTests.Schedule(new TakeDateTime().appointDateTime());
            }
            else
            {

                Boolean b = AppointmentTests.IsAfternoonAppointment(new TakeDateTime().appointDateTime());


                if (b == true)
                {
                    Console.WriteLine("\nAfternoon Appointment.");
                }
                else
                {
                    Console.WriteLine("\nNo Afternoon Appointment.");
                }
            }

            string desc = AppointmentTests.Description(new TakeDateTime().appointDateTime());
            Console.WriteLine(desc);

            Console.WriteLine("\nAnniversary date is on {0}", AppointmentTests.AnniversaryDate());
            Console.ReadKey();

        }

        private class TakeDateTime
        {
            public TakeDateTime()

            { }

            internal DateTime appointDateTime()
            { 
             throw new NotImplementedException();
             //NewMethod()
            }


        }
    }
}



