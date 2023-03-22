using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        //2422
        //14501
        static StringBuilder sb = new StringBuilder();
        static int n, m;
        static bool[] visit;
        static int[,] map;
        static int count = 0;
        static void Main(string[] args)
        {
            int[] read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            n = read[0];
            m = read[1];
            visit = new bool[n + 1];
            map = new int[n + 1, n + 1];

            for(int i = 0; i < m; i++)
            {
                int[] read2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                map[read2[0], read2[1]] = map[read2[1], read2[0]] = 1;
            }
            dfs(1, 0, new int[3]);
            sb.Append(count);
            Console.WriteLine(sb);
        }

        public static void dfs(int val, int selidx, int[] sel)
        {
            if (selidx == 3)
            {
                if (map[sel[0],sel[1]] == 1 || map[sel[1], sel[2]] == 1 || map[sel[0], sel[2]] == 1)
                    return;
                count++;
                return;
            }
            if (val == n + 1)
                return;
            sel[selidx] = val;
            dfs(val + 1, selidx + 1, sel);
            dfs(val + 1, selidx, sel);
        }
    }
}
