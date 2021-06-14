/*
https://www.interviewbit.com/problems/sorted-insert-position/
Given a sorted array A and a target value B, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You may assume no duplicates in the array.

*/
public class FindPosition
{
    public static int solve(List<int> A, int B)
    {
        return solve(A, B, 0, A.Count - 1);
    }
    public static int solve(List<int> A, int B, int left, int right)
    {
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (A[mid] == B)
                return mid;

            else if (B < A[mid])
            {
                return solve(A, B, 0, mid - 1);
            }
            else
            {
                return solve(A, B, mid + 1, right);
            }
        }
        return left;
    }
}
