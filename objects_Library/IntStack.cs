using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntStack
{                      
    private const int maxsize = 10;
    private int top = 0;
    private int[] array = new int[maxsize];

    public void Push(int value)
    {
        if (IsFull())
            throw new InvalidOperationException("Stack is full");

        array[top++] = value;
    }

    public int Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        return array[--top];
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        return array[top - 1];
    }

    public bool IsEmpty() { return top == 0; }
    public bool IsFull() { return top == maxsize; }
    public int Count() { return top; }
}
