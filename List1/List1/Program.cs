using System;
using System.Collections.Generic;
using System.Linq;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadLine();
        }
        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> e = nums.Select(x => 5 * (x + 2));
            return e.ToList();
            //Console.ReadLine();
        }

        //Console.ReadLine();
    }
 
}
