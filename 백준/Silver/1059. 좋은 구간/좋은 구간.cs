using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int L;
        static int[] s;
        static int n;
        static void Main(string[] args)
        {
            L = int.Parse(Console.ReadLine());
            s = Console.ReadLine().Split().Select(int.Parse).ToArray();
            n = int.Parse(Console.ReadLine());
            Array.Sort(s);

            int max = 1, min = 1, cnt = 0;

            for(int i = 0; i < L; i++)
            {
                if(n <= s[i])
                {
                    max = s[i];
                    break;
                }
                min = s[i] + 1;
            }

            for(int i = min; i < max; i++)
            {
                for(int j = i + 1; j < max; j++)
                {
                    if (i <= n && n <= j)
                        cnt++;
                }
            }

            sb.Append(cnt);
            Console.WriteLine(sb);

        }

    }
}
