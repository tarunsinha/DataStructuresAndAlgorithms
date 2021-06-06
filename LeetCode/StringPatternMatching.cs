using System;

public class StringPatternMatching
{
    
    /// <summary>
    /// Brute force method comparing each character of pattern to text
    /// by sliding pattern one char at a time.
    /// Running Time Complexity - O(m*(n-m+1))
    /// </summary>
    /// <param name="text"></param>
    /// <param name="pattern"></param>
    public static void Search(string text, string pattern)
    {
        int m = pattern.Length;
        int n = text.Length;

        for (int i = 0; i <= n - m; i++)
        {
            int j = 0;
            for (j = 0; j < m; j++)
            {
                if (text[i + j] != pattern[j])
                    break;
            }

                if (j == m)
                    Console.WriteLine("pattern found at: " + i);
        }
    }
}