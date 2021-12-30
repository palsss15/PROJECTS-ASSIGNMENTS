using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("abc"));
            Console.WriteLine(test("cdaef"));
            Console.WriteLine(test("js"));
            Console.WriteLine(test("php"));
            Console.ReadLine();

        }
        public static string test(string str )
        {
            return str.Substring(1, 2).Equals("a") ? str.Remove(1,2) : str ;
            //Console.ReadLine();
        }
       
    }
}
