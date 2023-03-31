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
        static int[] k;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            k = new int[n];
            for(int i = 0; i < n; i++)
            {
                k[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(k);
            Array.Reverse(k);
            long tip = 0;
            for (int i = 0; i < n; i++)
            {
                if(k[i] - i > 0)
                    tip += k[i] - i;
            }

            sb.Append(tip);

            Console.WriteLine(sb);
        }
    }
}
