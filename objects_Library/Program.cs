using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objects_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Leland");
            Person person2 = new Person("Mark");
            person2.Age = 22;

            Console.WriteLine("My name is {0}, and I am {1} years old!", person1.Name, person1.Age);
            Console.WriteLine("My name is {0}, and I am {1} years old!", person2.Name, person2.Age);
        }
    }
}
