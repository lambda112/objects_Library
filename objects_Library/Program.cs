using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace objects_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntStack test = new IntStack();

            test.Push(10);
            test.Push(20);
            test.Push(30);
            //Console.WriteLine(test.Pop());
            //Console.WriteLine(test.Peek());

            //    Person person1 = new Person("Leland");
            //    Person person2 = new Person("Mark");
            //    person2.Age = 22;

            //    Book book1 = new Book(person1, "Last Dance");

            //    Console.WriteLine("My name is {0}, and I am {1} years old!", person1.Name, person1.Age);
            //    Console.WriteLine("My name is {0}, and I am {1} years old!", person2.Name, person2.Age);
            //    Console.WriteLine(person1.CompareTo(person2)); // -1 means value is smaller, 0 means value is equal, 1 means value is bigger

            Book[] books = new Book[3];

            books[0] = new Book(new Person("pmpm"), "mpmp");
            books[1] = new Horror("IT");
            books[2] = new Book(new Person("sdsd"), "dsds");

            BookStack reading = new BookStack();
            reading.Push(books[0]);
            reading.Push(books[1]);
            reading.Push(books[2]);

            Console.WriteLine("Count: " + reading.Count());
            Console.WriteLine("Removed: " + reading.Pop().Title);
            Console.WriteLine("Next: " + reading.Peek().Title);
            Console.WriteLine("Count: " + reading.Count());


            //foreach (Book book in books)
            //{
            //    Console.WriteLine("{0}  {1}", book.Author.Name, book.Title);
            //}

            //books[2].GetSummary();

        }
    }
}
