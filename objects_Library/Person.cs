using System;

public class Person : IComparable
{
    private int age;
    private string name;

    public Person(string name)
    {
        Name = name;
        age = 18;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
            {
                age = value;
            }

            else
            {
                Console.WriteLine("Age cannot be smaller than 0!");
            }
        }
    }

    public int CompareTo(object obj)
    {
        Person other = (Person)obj;
        return Name.CompareTo(other.Name);
    }
}
