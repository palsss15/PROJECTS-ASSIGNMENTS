using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using static Booking.Program;
using System.Collections;


namespace Booking
{
    class AppointmentTests
    {
        static List<DateTime> list = new List<DateTime>();
        static DateTime dt1, dt2, dt3, dt4, dtTm;
        static string value, desc, anni;
        public static void Schedule(DateTime dateTime1)
        {
            dt1 = dateTime1;
            list.Add(dt1);
            Console.WriteLine("Appointment is scheduled for :{0}", dt1.ToString());
        }
        public static Boolean HasPassed(DateTime dateTime2)
        {
            dt2 = dateTime2;
            foreach (var date in list)
            {
                if (date.Date == dt2.Date)
                    dtTm = date.Date;
            }
            if (dtTm == dt2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("This Date and Time is available,applying for an appointment for this date and time.");
                Schedule(dt2);
                return false;
            }
        }
        public static Boolean IsAfternoonAppointment(DateTime dateTime3)
        {
            dt3 = dateTime3;
            TimeSpan start = new TimeSpan(12, 0, 0);
            TimeSpan end = new TimeSpan(18, 0, 0);
            TimeSpan onlyTime = new TimeSpan(00, 0, 0);
            foreach (var item in list)
            {
                if (item.Date == dt3)
                    onlyTime = item.TimeOfDay;
            }
            if ((onlyTime >= start) && (onlyTime < end))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string Description(DateTime dateTime4)
        {
            dt4 = dateTime4;
            foreach (var item in list)
            {
                if (item.Date == dt4)
                {
                    desc = item.ToString();
                }
            }
            return desc;
        }
        public static string AnniversaryDate()
        {
            DateTime anvDt = new DateTime(2021, 01, 15);
            anni = anvDt.Date.ToString();
            return anni;

        }
    }
}
