using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsStack
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            int num = 3;

            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                stack.Push(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            for (int i = 0; i < num; i++)
            {
                Person p = (Person) stack.Pop();
                Console.WriteLine(p.ToString());
                //Console.ReadLine();
              
            }
            Console.ReadLine();
        }
    }
}
