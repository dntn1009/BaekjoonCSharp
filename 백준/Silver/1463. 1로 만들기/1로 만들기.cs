using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int x = int.Parse(Console.ReadLine());
            int[] dp = new int[x + 1];
            dp[0] = dp[1] = 0;

            for (int i = 2; i <= x; i++)
            {
                dp[i] = dp[i - 1] + 1;

                if (i % 2 == 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
                }
                if (i % 3 == 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
                }
            }
            sb.Append(dp[x]);
            Console.WriteLine(sb);
        }

    }
}