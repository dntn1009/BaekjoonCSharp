using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        static int n, weight;

        static void Main(string[] args)
        {
           int[] answer = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            n = answer[0];
            weight = answer[1];
            // 물건 개수와 최대 무게 정함.

            int[,] dp = new int[n + 1, weight + 1];
            // 다이나믹 프로그래밍 dp 배열

            for(int i = 1; i <= n; i++)
            {
                int[] obj = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int w = obj[0];
                int v = obj[1];
                // 물건의 무게와 가치


                for(int j = 1; j <= weight; j++)
                { // 무게 1 부터 최대 무게까지
                    if (w <= j) // j가 물건의 무게보다 같거나 크면
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - w] + v); 
                        // j에서 현재의 무게를 뺀 전에 찾은 총 무게에 현재 무게의 가치를 더하여 총 가치를 넣어줌
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                        // 전에 무게의 총 가치를 현재 무게에 넣어줌
                    }
                }
            }

            sw.WriteLine(dp[n, weight].ToString());
            sw.Close();
            
        }
    }
}
