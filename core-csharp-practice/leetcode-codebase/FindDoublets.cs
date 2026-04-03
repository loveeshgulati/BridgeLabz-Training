
using System;

class FindDoublets
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
        int x = 9;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == x)
                {
                    Console.WriteLine(arr[i] + " " + arr[j]);
                }
            }
        }
    }
}
