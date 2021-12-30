using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student
    {


        private int rollNo;
        private string name;
        private string courseJoined;
        private double feePaidFar;
        /// <summary>
        /// Constructor
        /// </summary>
        public Student() { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rollNo"></param>
        /// <param name="name"></param>
        /// <param name="courseJoined"></param>
        /// <param name="feePaidFar"></param>
        public Student(int rollNo, string name, string courseJoined, double feePaidFar)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.courseJoined = courseJoined;
            this.feePaidFar = feePaidFar;
        }
        /// <summary>
        /// display info
        /// </summary>
        public void display()
        {
            Console.WriteLine("Roll No: {0}", rollNo);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Course joined: {0}", courseJoined);
            Console.WriteLine("Fee paid so far: {0}", feePaidFar);
        }
    }
}
        



    


