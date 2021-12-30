using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_NO2
{
    class Program
    {
        static void Main(string[] args)
        {
            string lName = Console.ReadLine();
            string fName = Console.ReadLine();
            int studId = Convert.ToInt32(Console.ReadLine());
            int NoOfSubject = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[NoOfSubject];

            for(int i = 0; i< arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Student studObj = new Student(lName, fName, studId,arr);

            Console.Write("Name: " + fName + ", " + lName + "\n" + "ID: " + studId + "\n" + "Grade: " + studObj.calculate());
            Console.ReadLine();
        }
    }
}
