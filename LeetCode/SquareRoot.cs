/*
https://www.interviewbit.com/problems/square-root-of-integer/
Given an integer A.

Compute and return the square root of A.

If A is not a perfect square, return floor(sqrt(A)).

DO NOT USE SQRT FUNCTION FROM STANDARD LIBRARY

*/
using System;

public class SquareRoot
{
    public static int sqrt(int A)
    {
        return sqrt(A, 0, A);
    }

    static int sqrt(int A, Int64 start, Int64 end)
    {
        if (start <= end)
        {
            Int64 mid = (Int64)(start + end) / 2;


            if ((mid * mid <= A) && ((mid + 1) * (mid + 1)) > A)
            {
                return (int)mid;
            }

            else if ((mid * mid) < A)
            {
                return sqrt(A, mid + 1, end);
            }
            else
            {
                return sqrt(A, start, mid - 1);
            }
        }
        return (int)start;
    }

}