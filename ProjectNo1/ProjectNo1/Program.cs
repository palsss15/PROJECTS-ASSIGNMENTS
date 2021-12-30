using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNo1
{
    class StudentAndTeacherTest
    {
        static void Main()
        {
            bool debug = false;
           
           // string firstName
            //Create a Person and make it say hello
            Person myPerson = new Person();
            myPerson.Greet();

            /*Create a student, set his age to 21, 
              tell him to Greet and display his age*/
            Student myStudent = new Student();
            myStudent.studentRollnum = 12345;
           // myStudent.age
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            /*Create a teacher, 30 years old, 
             *ask him to say hello and then explain*/
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

            if (debug)    //if(debug==true)
               Console.ReadLine();
            Console.ReadKey();
        }

    }
}