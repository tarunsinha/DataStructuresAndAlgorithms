public class MinStack
{
    Stack<int> st1; Stack<int> minSt;
    /** initialize your data structure here. */
    public MinStack()
    {
        st1 = new Stack<int>();
        minSt = new Stack<int>();
        string st = "";
        var s = st.Split(new char['.', ':'], System.StringSplitOptions.RemoveEmptyEntries);
    }

    public void Push(int val)
    {
        if (st1.Count == 0)
        {
            st1.Push(val);
            minSt.Push(val);
        }
        else
        {
            st1.Push(val);
            var minVal = minSt.Pop();
            minSt.Push(minVal);

            if (minVal > val)
            {
                minSt.Push(val);
            }
            else
            {
                minSt.Push(minVal);
            }
        }
    }

    public void Pop()
    {
        int t = st1.Pop();
        minSt.Pop();
    }

    public int Top()
    {
        int t = st1.Pop();
        st1.Push(t);
        return t;
    }

    public int GetMin()
    {
        int t = minSt.Pop();
        minSt.Push(t);
        return t;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */