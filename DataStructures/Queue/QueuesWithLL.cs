using System;

public class QueuesWithLL
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

    public void Enqueue(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        var temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
        return;
    }

    public void Dequeue()
    {
        Console.WriteLine("Dequeued " + head.data);
        head = head.next;
    }

    public void Peek()
    {
        Console.WriteLine("Queue first: " + head.data);
    }
    public void PrintQueue()
    {
        var temp = head;

        while (temp != null)
        {
            System.Console.Write(temp.data + " ");
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