using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student studentMary = new Student(4546, "Mary", "C#", 2000);
            Student studentMike = new Student(2131, "Mike", " ASP.NET", 3000);
            studentMary.display();
            Console.WriteLine();
            studentMike.display();
            Console.ReadLine();
        }
    }
}
