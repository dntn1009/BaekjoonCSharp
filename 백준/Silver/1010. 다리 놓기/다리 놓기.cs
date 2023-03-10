using System;
using System.Linq;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

        static int n;
        static long[] value;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            
            for(int i = 0; i < n; i++)
            {
                int[] LRPos = Console.ReadLine().Split().Select(int.Parse).ToArray();

                sb.Append(Max(LRPos[0], LRPos[1]));
                if (i != n - 1)
                    sb.Append("\n");
            }

            Console.WriteLine(sb);
        }
        
        public static long Max(int left, int right)
        {
            long value = 1;

            int t = 1;

            for (int i = right; i > right - left; i--)
            {
                    value *= i;
                    value /= t++;
            }

            return value;
        }
    }
}

