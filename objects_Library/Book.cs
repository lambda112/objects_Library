using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

class BookStack
{
    private const int maxsize = 10;
    private int top = 0;
    private Book[] array = new Book[maxsize];

    public void Push(Book book)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("Stack is Full!");
        }

        array[top++] = book;
    }

    public Book Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is Empty!");
        }

        return array[--top];
    }

    public Book Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is Empty!");
        }

        return array[top - 1];
    }

    public bool IsEmpty()
    {
        return top == 0;
    }

    public bool IsFull()
    {
        return top == maxsize;
    }

    public int Count()
    {
        return top;
    }
}