using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop1 L = new Laptop1();

            L.ShowFunct(Laptop1.Lenovo, Laptop1.Price1000, Laptop1.i3, Laptop1.RAM2GB, Laptop1.HD500GB);
           
            L.ShowFunct(Laptop1.HP, Laptop1.Price3500, Laptop1.i5, Laptop.RAM4GB, Laptop1.HD800GB);
           
            L.ShowFunct(Laptop1.DELL, Laptop1.Price5000, Laptop1.i7, Laptop.RAM8GB, Laptop1.HD1TB);
            
            Console.ReadKey();
        }
    }
}
