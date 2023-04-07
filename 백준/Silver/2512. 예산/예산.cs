using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        //2512
        static StringBuilder sb = new StringBuilder();
        static int n, m, total, result;
        static int[] value;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            value = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxbudget = 0;

            for(int i = 0; i < n; i++)
            {
                maxbudget = Math.Max(maxbudget, value[i]);
            }

            m = int.Parse(Console.ReadLine());

            int low = 0, high = maxbudget;
            
            while(low <= high)
            {
                int mid = (low + high) / 2;
                long sum = 0;
                for (int i = 0; i < n; i++)
                    sum += Math.Min(value[i], mid);

                if (sum <= m)
                {
                    result = mid;
                    low = mid + 1;
                }
                else
                    high = mid - 1;
            }

            sb.Append(result);
            Console.WriteLine(sb);

        }
    }
}
