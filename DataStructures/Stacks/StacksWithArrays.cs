using System;
public class Stacks<T>
{
    int size;
    T[] stack;
    int top;

    public int Count
    {
        get
        {
            return top;
        }
    }
    public Stacks(int size)
    {
        stack = new T[size];
        top = -1;
        this.size = size;
    }

    public void Push(T data)
    {
        if (top >= size)
        {
            System.Console.WriteLine("Stack Overflow");
        }
        else
        {
            stack[top + 1] = data;
            top++;
        }
    }

    public T Pop()
    {
        if (top < 0)
        {
            System.Console.WriteLine("Stack Underflow");
            return default;
        }
        else
        {
            top--;
            return stack[top + 1];
        }
    }
    public void Peek()
    {
        if (top < 0)
            System.Console.WriteLine("Stack Underflow");
        else
            System.Console.WriteLine(stack[top]);
    }

    public void PrintStack()
    {
        if (top < 0)
            System.Console.WriteLine("Stack Underflow");
        else
        {
            for (int i = top; i >= 0; i--)
            {
                System.Console.WriteLine(stack[i]);
            }
        }

    }

}

public class StackDriver
{
    public static void ExecuteStack()
    {
        Stacks<int> st = new Stacks<int>(10);
        for (int i = 1; i < 5; i++)
        {
            st.Push(i);
        }
        st.PrintStack();
        st.Pop();
        st.PrintStack();
        st.Peek();
        st.Pop();
        st.PrintStack();
        st.Push(1002);
        st.PrintStack();
    }
}