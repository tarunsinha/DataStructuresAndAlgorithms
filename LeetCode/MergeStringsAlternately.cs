using System;
using System.Text;
class Program
{
    public string MergeAlternately(string word1, string word2)
    {
        var word1Array = word1.ToCharArray();
        var word2Array = word2.ToCharArray();
        int word1ArrayLength = word1Array.Length;
        int word2ArrayLength = word2Array.Length;
        StringBuilder sb = new StringBuilder();
        int i = 0, j = 0;
        while (word1ArrayLength > 0 && word2ArrayLength > 0)
        {
            sb.Append(word1[i++]);
            sb.Append(word2[j++]);
            word1ArrayLength--;
            word2ArrayLength--;
        }

        while (word1ArrayLength > 0)
        {
            sb.Append(word1[i++]);
            word1ArrayLength--;
        }

        while (word2ArrayLength > 0)
        {
            sb.Append(word2[j++]);
            word2ArrayLength--;
        }
        return sb.ToString();
    }
}