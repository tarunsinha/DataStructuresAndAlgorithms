using System;
public class TappingRainWater
{
    public static int Trap()
    {
        var height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int n = height.Length;
        if (n <= 0) return 0;
        int[] left = new int[n];
        int[] right = new int[n];
        left[0] = height[0];
        right[n - 1] = height[n - 1];
        // Fill Left array
        // [0,1,0,2,1,0,1,3,2,1,2,1]
        for (int i = 1; i < n; i++)
        {
            left[i] = Math.Max(left[i - 1], height[i]);
        }

        // Fill right array starting from last index
        for (int i = n - 2; i >= 0; i--)
        {
            right[i] = Math.Max(right[i + 1], height[i]);
        }

        int result = 0;
        // F(i) = Min(left[i],right[i]) - height[i]
        for (int i = 0; i < n; i++)
        {
            result += Math.Min(left[i], right[i]) - height[i];
        }
        return result;
    }
}