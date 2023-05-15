using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int[,] dp;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            dp = new int[n + 1, 3];
            dp[0, 0] = 1;

            if(n != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    dp[i, 0] = dp[i - 1, 0] + dp[i - 1, 1] + dp[i - 1, 2];
                    dp[i, 1] = dp[i - 1, 0] + dp[i - 1, 2];
                    dp[i, 2] = dp[i - 1, 0] + dp[i - 1, 1];

                    dp[i, 0] %= 9901;
                    dp[i, 1] %= 9901;
                    dp[i, 2] %= 9901;
                }
            }
            sb.Append((dp[n, 0] + dp[n, 1] + dp[n, 2]) % 9901);

            Console.WriteLine(sb);
        }
    }
}
