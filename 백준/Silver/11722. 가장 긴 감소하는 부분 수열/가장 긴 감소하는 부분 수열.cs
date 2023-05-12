using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int[] map;
        static int[] dp;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            map = Console.ReadLine().Split().Select(int.Parse).ToArray();
            dp = new int[n];
            int count = 1;
            if (n == 1)
            {
                sb.Append(count);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if(dp[i] == 0)
                        dp[i] = 1;
                    
                    if(i != n - 1)
                        for(int j = i + 1; j < n; j++)
                        {
                            if (map[i] > map[j])
                                dp[j] = Math.Max(dp[i] + 1, dp[j]);
                        }
                }

                for(int i = 0; i < n; i++)
                {
                    count = Math.Max(dp[i], count);
                }
                sb.Append(count);
            }
            
            Console.WriteLine(sb);
        }
    }
}
