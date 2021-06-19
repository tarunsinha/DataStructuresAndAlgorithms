public class MaxArea
{
    public int MaxArea(int[] height)
    {
        int l = 0, r = height.Length - 1;
        int area = 0;
        while (l < r)
        {
            area = Math.Max(area, (r - l) * Math.Min(height[l], height[r]));

            if (height[l] < height[r]) l++;
            else r--;
        }
        return area;
    }
}

/* Naive Solution O(N^2)
public int MaxArea(int[] height) {
        int n = height.Length;
        int area=0;
        for(int i=0;i<n;i++){
            for(int j =i+1;j<n;j++){
                area = Math.Max(area, (j-i) * Math.Min(height[i], height[j]));
            }
        }
        
        return area;
    }
*/