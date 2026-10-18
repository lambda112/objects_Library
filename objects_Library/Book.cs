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

    public Book(string title, Person author)
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
}