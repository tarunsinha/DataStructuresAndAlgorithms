using System;

public class DuplicateInArray
{
    /// <summary>
    /// Elements in the array is from 0 to n-1 and all of them are positive
    /// Run time O(n) and constant space O(1)
    /// </summary>
    /// <param name="arr"></param>
    public void FindDuplicatesInArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            arr[arr[i] % n] = arr[arr[i] % n] + n;
        }
        for (int i = 0; i < n; i++)
        {
            if (arr[i] >= 2 * n)
                System.Console.WriteLine(i);
        }
    }

    /// <summary>
    /// finds duplicate wher each duplicate in repeated at mots 2 times
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public List<int> FindDuplicates_Two(int[] arr)
    {
        list<int> lstInt = new list<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            int j = Math.Abs(arr[i]);
            if (arr[j] >= 0)
                arr[j] = -arr[j];
            else
                lstInt.Add(j);
        }
        return lstInt;
    }
}