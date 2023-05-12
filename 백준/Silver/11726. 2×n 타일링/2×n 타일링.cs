using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int[] map;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            map = new int[n];

            if (n == 1)
                map[0] = 1;
            else if (n == 2)
            {
                map[0] = 1;
                map[1] = 2;
            }
            else
            {
                map[0] = 1;
                map[1] = 2;
                for (int i = 2; i < n; i++)
                {
                    map[i] = (map[i - 2] + map[i - 1]) % 10007;
                }
            }
            sb.Append(map[n - 1]);
            Console.WriteLine(sb);
        }
    }
}
