using System;

public class StacksWithLL
{
    private class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }

    }
    Node head = null;

    public void Push(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        newNode.next = head;
        head = newNode;
    }

    public void Pop()
    {
        Console.WriteLine("Popped stack top: " + head.data);
        head = head.next;
    }

    public void Top()
    {
        Console.WriteLine("Popped stack top: " + head.data);
    }
    public void PrintStack()
    {
        var temp = head;

        while (temp != null)
        {
            System.Console.WriteLine(temp.data + " ");
            temp = temp.next;
        }
    }
}

public class StacksWithLLDriver
{
    public void ExecuteStackWithLL()
    {
        StacksWithLL st = new StacksWithLL();
        int[] arr = new int[] { 1, 2, 3, 4, 5 };
        for (int i = 0; i < arr.Length; i++)
        {
            st.Push(i);
        }
        st.PrintStack();

        st.Pop();
        st.PrintStack();
        st.Pop();
        st.Pop();
        st.PrintStack();
    }
}