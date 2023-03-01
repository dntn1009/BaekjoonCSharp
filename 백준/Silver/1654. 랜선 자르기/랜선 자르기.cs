using System;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //1654
            StringBuilder sb = new StringBuilder();
            int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = x[0];// 이미 가지고 있는 K
            int n = x[1];// 만들어야 하는 N
            long[] num = new long[k];

            long start = 1;
            long max = 0;

            for(int i = 0; i < k; i++)
            {
                long y = long.Parse(Console.ReadLine());
                num[i] = y;
                if (max < y)
                    max = y;
            }

            long result = 0;

            while(start <= max)
            {
                long mid = (start + max) / 2;
                long cut = 0;
                for(int i = 0; i < k; i++)
                {
                    if (num[i] / mid != 0)
                        cut += (num[i] / mid);
                }

                if (cut >= n)
                {
                    if (result < mid)
                        result = mid;
                    start = mid + 1;
                }
                else
                    max = mid - 1;
            }

            sb.Append(result);
            Console.WriteLine(sb);
        }

    }
}