public class Solution
{
    public int SingleNumber(int[] nums)
    {
        List<int> n = new List<int>();
        foreach (int i in nums)
        {
            if (n.Contains(i))
                n.Remove(i);
            else
                n.Add(i);
        }
        return n[0];
    }
}