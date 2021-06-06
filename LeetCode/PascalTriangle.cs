using System;

public class Pascals
{
    public static List<List<int>> PascalTriangle(int A)
    {
        List<List<int>> lstInt = new List<List<int>>();
        for (int line = 1; line <= A; line++)
        {
            int C = 1;
            List<int> lsIn = new List<int>();
            for (int i = 1; i <= line; i++)
            {
                lsIn.Add(C);
                C = C * (line - i) / i;
            }
            lstInt.Add(lsIn);
        }

        return lstInt;
    }
}