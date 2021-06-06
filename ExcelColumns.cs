using System;
public class ExcelColumns
{
    public int TitleToNumber(string columnTitle)
    {
        int res = 0;
        for (int i = 0; i < columnTitle.Length; i++)
        {
            res *= 26;
            res += columnTitle[i] - 'A' + 1;
        }
        return res;
    }

    public string ConvertToTitle(int columnNumber)
    {
        StringBuilder sb = new StringBuilder();
        //string sb = "";
        while (columnNumber > 0)
        {
            int rem = columnNumber % 26;

            if (rem == 0)
            {
                sb.Append('Z');
                columnNumber = columnNumber / 26 - 1;
            }
            else
            {
                sb.Append((char)((rem - 1) + 'A'));
                columnNumber /= 26;
            }
        }

        var charArray = sb.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new String(charArray);
    }

}