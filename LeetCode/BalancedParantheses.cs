public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> st = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                st.Push(s[i]);

            else if (s[i] == ')' || s[i] == '}' || s[i] == ']')
            {
                if (st.Count == 0) return false;
                var topStack = st.Pop();
                if ((topStack == '(' && s[i] == ')') ||
                   (topStack == '{' && s[i] == '}') ||
                   (topStack == '[' && s[i] == ']'))
                    continue;
                else return false;
            }
        }
        if (st.Count == 0)
            return true;
        else return false;
    }
}