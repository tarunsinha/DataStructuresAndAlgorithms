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

    public int SingleNumberUsingXOR(int [] nums){
        // Any number XOR with 0 is that number
        // Any number XOR with itself is 0
        // Therefore [5,4,1,4,3,5,1]
        // XOR each number with the other one gives 0 when two numbers are same
        // Last number would be the remaining number which is the number with single occurence
        int a =0;
        foreach (int i in num)
        {
            a = a^i;
        }
        return a;
    }
}