using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNo1
{
    class Student : Person
    {
        private int age = 25;
        public int studentRollnum = 123;
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }

        public int GetAge()
        {
            return age;
        }
    }

}
