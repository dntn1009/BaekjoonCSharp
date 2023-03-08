using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

        static int[] A;
        static int[] C;
        static int N, M;
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            M = int.Parse(Console.ReadLine());

            C = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(A);

            for (int i = 0; i < M; i++)
            {
                int find = C[i];

                sb.Append(binarySearch(find));
                if (i != M - 1)
                    sb.Append("\n");

            }

            Console.WriteLine(sb);

        }

        public static int binarySearch(int n)
        {
            int start = 0;
            int end = N - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (n < A[mid])
                    end = mid - 1;
                else if (n > A[mid])
                    start = mid + 1;
                else
                    return 1;
            }
            return 0;
        }
  
    }
}
