using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileH
{
    class Program
    {
        static void Main(string[] args)
        {



            string filePath = @"D:\csharp\example.dat";
            string line;
            string fileContent = " ";
            int i=1;

            if (File.Exists(filePath))
            {
                StreamReader file = null;
                try
                {
                    file = new StreamReader(filePath);
                    Console.WriteLine("Id \t Source \t Destination  \t   Date   \t Status \t Network");

                    while ((line = file.ReadLine()) != null)

                    {
                        if (line.Contains("Id") || line.Contains("Source") || line.Contains("Destinaion") || line.Contains("Date") || line.Contains("Status") || line.Contains("Network"))
                        {
                            line = line.Split(':').Last();

                            Console.Write(line);
                            fileContent += line;
                        }
                    }
                }

                finally
                {
                    if (file != null)
                        file.Close();
                }

                Console.ReadKey();
            }


        }

    }
}