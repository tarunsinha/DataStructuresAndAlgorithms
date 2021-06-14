/*
https://www.interviewbit.com/problems/matrix-search/
Given a matrix of integers A of size N x M and an integer B.

Write an efficient algorithm that searches for integar B in matrix A.
*/
public class Solution
{
    public int searchMatrix(List<List<int>> A, int B)
    {
        int n = A.Count;
        int m = A[0].Count;

        int l = 0, r = n - 1, mid = 0;

        while (l <= r)
        {
            mid = l + (r - l) / 2;

            if (A[mid][0] == B) return 1;
            if (A[mid][m - 1] == B) return 1;

            if (B > A[mid][0] && B < A[mid][m - 1]) // B must be in this row 
                return binarySearch(A, B, n, m, mid);

            if (B < A[mid][0])
                r = mid - 1;
            if (B > A[mid][m - 1])
                l = mid + 1;
        }
        return 0;
    }

    int binarySearch(List<List<int>> A, int B, int n, int m, int row)
    {
        int l = 0, r = m - 1, mid = 0;

        while (l <= r)
        {
            mid = l + (r - l) / 2;

            if (A[row][mid] == B) return 1;

            if (B < A[row][mid])
                r = mid - 1;
            if (B > A[row][mid])
                l = mid + 1;
        }
        return 0;
    }
}
