using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int N;
        static int S;
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            S = int.Parse(Console.ReadLine());

            int start = 0;

            while(start < N && S > 0)
            {
                int maxi = start;

                for(int i = start; i <= Math.Min(N - 1, start + S); i++)
                {
                    if (arr[maxi] < arr[i]) maxi = i;
                }

                for(int i = maxi; i >start; i--)
                {
                    int temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;
                    S--;
                }

                start++;
            }
           
            for (int i = 0; i < N; i++)
            {
                sb.Append(arr[i]);
                if (i != N - 1)
                    sb.Append(" ");
            }

            Console.WriteLine(sb);

        }
    }
}
