using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int n;
        static int[] a, b;
        static bool[] check;
        static long s;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            check = new bool[n];

            int checknum = 0;
            int big = 0;
            int lastbig = 100;
            Array.Sort(a);

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (b[j] > big && !check[j])
                    {
                        big = b[j];
                        checknum = j;
                    }
                }
                s += big * a[i];
                lastbig = big;
                check[checknum] = true;
                big = 0;
            }
            sb.Append(s);
            Console.WriteLine(sb);
        }

    }
}
