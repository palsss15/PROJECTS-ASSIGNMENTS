using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main()
        {


            void ReadHouse()

            {
                FileStream filestremObj = new FileStream("D:\\csharp\\MyFile.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(filestremObj);
                while (sr.Peek() > 0)
                {
                    string readmyline = sr.ReadLine();
                    string[] strings = readmyline.Split(':');
                    if (strings.Length > 1)
                        Console.WriteLine(strings[1]);
                }
            }
        }
    }
}


