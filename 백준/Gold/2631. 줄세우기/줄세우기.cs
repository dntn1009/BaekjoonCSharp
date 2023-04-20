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
        static int[] order;
        static int[] DP;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            order = new int[n];
            DP = new int[n];
            for(int i = 0; i < n; i++)
            {
                order[i] = int.Parse(Console.ReadLine());
            }


            sb.Append(n - dp());
            Console.WriteLine(sb);
        }

        static public int dp()
        {
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                DP[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (order[j] < order[i] && DP[i] < DP[j] + 1)
                    {
                        DP[i] = DP[j] + 1;
                    }
                }
                result = Math.Max(result, DP[i]);
            }

            return result;
        }
    }
}