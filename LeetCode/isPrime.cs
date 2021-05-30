using System;

public class FindPrime
{
    public static void Main(string[] args)
    {
        int n = 100;
        bool[] isPrime = SeiveOfEratosthenes(n);
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"{i} is Prime: {isPrime[i]}");
        }

        System.Console.WriteLine("GCD: " + gcd(98, 96));
    }

    private static bool[] SeiveOfEratosthenes(int v)
    {
        bool[] isPrime = new bool[v + 1];
        Array.Fill(isPrime, true);
        isPrime[0] = false;
        isPrime[1] = false;
        for (int i = 2; i * i <= v; i++)
        {
            for (int j = 2 * i; j <= v; j += i)
                isPrime[j] = false;
        }
        return isPrime;
    }

    static int gcd(int a, int b)
    {
        if (b == 0)
            return a;
        return gcd(b, a % b);
    }
}