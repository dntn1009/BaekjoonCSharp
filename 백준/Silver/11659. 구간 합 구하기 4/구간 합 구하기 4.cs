using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        static int[] Sum = Enumerable.Repeat<int>(0, 100001).ToArray<int>();
        static int n, m;

        static void Main(string[] args)
        {
            // 입력 받기
            int[] input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            n = input[0];
            m = input[1];
            
            int[] num = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            numberSum(num);


            numberSearch();
            sw.Write(sb.ToString());
            sw.Close();
        }

        static public void numberSum(int[] num)
        {
            for(int i = 0; i < n; i++)
            {
                Sum[i + 1] = num[i];
                if(i != 0)
                    Sum[i + 1] += Sum[i];
            }
        }
        static public void numberSearch()
        {
            for(int i = 0; i < m; i++)
            {
                int[] part = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                sb.AppendLine((Sum[part[1]] - Sum[part[0] - 1]).ToString());
            }
        }
    }
}