using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static long a, b;
        static void Main(string[] args)
        {
            long[] read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            a = read[0];
            b = read[1];
            sb.Append(dfs(a));
            Console.WriteLine(sb);

        }

        static public int dfs(long first,int count = 1)
        {
            if (first == b)
                return count;
            else if (first > b)
                return -1;

            long two = long.Parse(first.ToString() + "1");

            int x = dfs(first * 2, count + 1);
            int y = dfs(two, count + 1);

            if (x != -1 && y != -1)
                return Math.Min(x, y);
            else if (x != -1)
                return x;
            else if (y != -1)
                return y;
            else
                return -1;
        }
    }
}
