using System;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
      

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n;
            long m;
            int[] want = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long[] wood = new long[1000000];
            n = want[0];
            m = want[1];

            int max = 1;

            string[] tree = Console.ReadLine().Split();

            for(int i = 0; i < n; i++)
            {
                wood[i] = int.Parse(tree[i]);

                if (wood[i] > max)
                    max = (int)wood[i];
            }

            int start = 0;
            int end = max;
            int result = 0;

            while(start <= end)
            {
                int mid = (start + end) / 2;
                long cut = 0;

                for(int i = 0; i < n; i++)
                {
                    if (mid < wood[i])
                        cut += wood[i] - mid;
                }

                if (cut >= m)
                {
                    if (result < mid)
                        result = mid;
                    start = mid + 1;
                }
                else
                    end = mid - 1;
            }

            sb.Append(result);
            Console.WriteLine(sb);

        }

    }
}
