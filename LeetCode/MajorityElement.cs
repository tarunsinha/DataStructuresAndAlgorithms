public class MajorityElement
{
    public static void FindMajorityElement(int[] arr)
    {
        int probableMajorityElementValue = arr[ProbableMajorityElement(arr)];
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == probableMajorityElementValue)
                count++;
        }
        if (count >= arr.Length / 2)
            System.Console.WriteLine($"Majority Element is {probableMajorityElementValue}");
        else
            System.Console.WriteLine("No majority element found");

    }
    public static int ProbableMajorityElement(int[] arr)
    {
        // [1,4,5,1,1]
        int ansIndex = 0, count = 1;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[ansIndex])
                count++;
            else count--;

            if (count == 0)
            {
                ansIndex = i;
                count = 1;
            }
        }
        return ansIndex;
    }

    //Dictionary method 
    // uses extra space of O(N)
    // Space Complexity O(N) and time complexity O(N)
    public static int MajorityElementUsingDict(int[] nums)
    {
        int cnt = nums.Length / 2;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            if (dict.ContainsKey(i))
            {
                dict[i]++;
            }
            else
            {
                dict.Add(i, 1);
            }
        }

        foreach (var kvp in dict)
        {
            if (kvp.Value > cnt)
                return kvp.Key;
        }
        return -1;
    }
}