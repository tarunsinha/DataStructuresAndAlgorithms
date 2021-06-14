/*
https://www.interviewbit.com/problems/smaller-or-equal-elements/

Given an sorted array A of size N. Find number of elements which are less than or equal to B.

NOTE: Expected Time Complexity O(log N)
*/
class SimilarOrEqualElements
{
    public int solve(List<int> A, int B)
    {
        int left = 0;
        int right = A.Count - 1;
        int count = 0;
        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (A[mid] <= B)
            {
                count = mid + 1;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return count;
    }
}

