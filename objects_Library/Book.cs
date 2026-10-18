using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book : IComparable
{
    private string title;
    private Person author;

    public Book(string title)
    {
        Title = title;
    }

    public Book(Person author, string title)
    {
        Title = title;
        Author = author;
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public Person Author
    {
        get { return author; }
        set { author = value; }
    }

    public int CompareTo(object obj)
    {
        Book other = (Book)obj;
        return Title.CompareTo(other.Title);
    }

    public void GetSummary()
    {
        Console.WriteLine("Title: {0}, Author: {1}, Author Age: {2}", title, author.Name, author.Age);
    }
}

class Horror: Book
{
    public Horror(string title) : base(title)
    {
        Author = new Person("Stephen King");
    }
}