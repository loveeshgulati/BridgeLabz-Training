
using System;

class Solution
{
    public static int CountPrimes(int n)
    {
        if (n <= 2) return 0;

        bool[] isPrime = new bool[n];
        for (int i = 0; i < n; i++)
            isPrime[i] = true;

        isPrime[0] = false;
        isPrime[1] = false;

        for (int i = 2; i * i < n; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j < n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        int count = 0;
        for (int i = 2; i < n; i++)
        {
            if (isPrime[i]) count++;
        }

        return count;
    }

    static void Main()
    {
        int n = 10;
        Console.WriteLine(CountPrimes(n));
    }
}
