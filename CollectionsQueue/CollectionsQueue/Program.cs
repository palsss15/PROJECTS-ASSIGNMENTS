using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue queue = new Queue();
            int total = 3;

            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                queue.Enqueue(new Personn()
                {
                    Name = name,
                    Age = age
                });
            }

            for (int i = 0; i < total; i++)
            {
                Personn p = (Personn)queue.Dequeue();
                Console.WriteLine(p.ToString());
            }
            Console.ReadLine();
        }
    }
}