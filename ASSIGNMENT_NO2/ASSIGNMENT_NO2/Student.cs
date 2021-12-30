using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_NO2
{
    class Student : Person
    {

        protected int id;
        protected int[] testScore;
        protected float avg;
        protected int total=0;

        public Student(string lastName, string firstName, int id, int[] testScore)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.id = id;
            this.testScore = testScore;
        }

        public char calculate()
        {
            for (int i = 0; i < testScore.Length; i++)
            {
                total += testScore[i];
            }
            avg = total / testScore.Length;

            if (avg >= 90 && avg <= 100)
            {
                return 'O';
            }
            else if (avg >= 80 && avg < 90)
            {
                return 'E';
            }
            else if (avg >= 70 && avg < 80)
            {
                return 'A';
            }
            else if (avg >= 55 && avg < 70)
            {
                return 'P';
            }
            else if (avg >= 40 && avg <= 55)
            {
                return 'd';
            }
            else return 'T';
        }

    }
}

