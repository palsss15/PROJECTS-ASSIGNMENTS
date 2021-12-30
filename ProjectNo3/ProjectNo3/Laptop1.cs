using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNo3
{
    class Laptop1 : Laptop
    {
        public void ShowFunct(string name, string price, string processor, string ram, string hd)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Processor : " + processor);
            Console.WriteLine("RAM : " + ram);
            Console.WriteLine("HD : " + hd);
        }
    }
}
