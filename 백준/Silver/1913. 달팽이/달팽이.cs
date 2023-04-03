using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int n, k;
        static int[,] map;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            map = new int[n, n];
            k = int.Parse(Console.ReadLine());
            int number = n * n;

            int t = 0, r = n;
            int x = 0, y = 0;

            while(number > 0)
            {
                x = t;
                y = t;
                for(int i = y; i < r; i++)
                {
                    map[i, x] = number--;
                }
                y = r - 1;
                for (int i = x + 1; i < r; i++)
                {
                    map[y, i] = number--;
                }
                x = r - 1;
                for (int i = y - 1; i >= t; i--)
                {
                    map[i, x] = number--;
                }
                y = t;
                for (int i = x - 1; i > t; i--)
                {
                    map[y, i] = number--;
                }
                t++;
                r--;
            }
            int q = 0, w = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (map[i, j] == k)
                    {
                        q = i + 1;
                        w = j + 1;
                    }
                    sb.Append(map[i, j] + " ");
                }
                sb.Append("\n");
            }
            sb.Append(q + " " + w);
            Console.Write(sb.ToString());
        }

    }
}
