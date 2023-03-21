using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        //14501
        static StringBuilder sb = new StringBuilder();
        static int n;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            int[] t = new int[n + 10];
            int[] p = new int[n + 10];
            int[] dp = new int[n + 10];
            int max = 0;
            for (int i = 1; i <= n; i++)
            {
                int[] read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                t[i] = read[0];
                p[i] = read[1];
            }

            for(int i = 1; i <= n + 1; i++)
            {
                dp[i] = Math.Max(dp[i], max);
                dp[t[i]+i] = Math.Max(dp[t[i] + i], p[i] + dp[i]);
                max = Math.Max(max, dp[i]);
            }

            sb.Append(max);

            Console.WriteLine(sb);
        }
    }
}
