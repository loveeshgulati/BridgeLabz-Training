
using System;

class JgdArray
{
    static void Main(string[] args)
    {
        int[][] num = new int[3][];

        num[0] = new int[4];
        num[1] = new int[8];
        num[2] = new int[5];

        num[0][0] = 2;
        num[0][1] = 5;
        num[1][0] = 1;
        num[1][1] = 3;
        num[2][0] = 12;

        for (int i = 0; i < num.Length; i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < num[i].Length; j++)
            {
                Console.Write(num[i][j] + " ");
            }
            Console.WriteLine("]");
        }
    }
}
