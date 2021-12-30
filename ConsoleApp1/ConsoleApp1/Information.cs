using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Information
    {
        public void getContactDetails()
        {
            FileStream filestreamObj = new FileStream(@"D:\csharp\example.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(filestreamObj);
            string[] str1 = new string[72];
            string[] str2 = new string[72];
            int index = 0;
            int x = 0;
            int y = 6;
            int z = 12;
            while (sr.Peek() > 0)
            {
                string readmyLine = sr.ReadLine();
                string[] strings = readmyLine.Split(':');
                if (strings.Length > 1)
                {
                    str1[index] = strings[0];
                    str2[index] = strings[1];
                    index++;
                }
            }
            for (int i = x; i < y; i++)
            {
                Console.Write(str1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            while (z > 0)
            {
                for (int i = x; i < y; i++)
                {
                    Console.Write(str2[i] + " ");
                }
                x = x + 6;
                y = y + 6;
                Console.WriteLine();
                Console.WriteLine();
                z = z - 1;
            }

            sr.Close();
            filestreamObj.Close();
        }
    }

}


