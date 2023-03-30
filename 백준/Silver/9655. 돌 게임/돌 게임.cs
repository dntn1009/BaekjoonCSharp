using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int[] dp = new int[1001];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = Math.Min(dp[i - 1] + 1, dp[i - 3] + 1);
            }

            if (dp[n] % 2 == 1)
            {
                sb.Append("SK");
            }
            else
            {
                sb.Append("CY");
            }

            Console.WriteLine(sb);
        }
    }
}
