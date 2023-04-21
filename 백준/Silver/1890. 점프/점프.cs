using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int n;
        static int[,] map;
        static long[,] dp;
        static void Main(string[] args)
        {
            //점프
            n = int.Parse(Console.ReadLine());
            map = new int[n, n];
            dp = new long[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] str = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    map[i, j] = str[j];
                }
            }
            dp[0, 0] = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dp[i, j] != 0 && map[i, j] != 0)
                    {
                        int num = map[i, j];
                        if(i + num >= 0 && i + num < n)
                            dp[i + num, j] += dp[i, j];
                        if (j + num >= 0 && j + num < n)
                            dp[i, j + num] += dp[i, j];
                    }
                }
            }

            sb.Append(dp[n - 1, n - 1]);
            Console.WriteLine(sb);
        }

    }
}
