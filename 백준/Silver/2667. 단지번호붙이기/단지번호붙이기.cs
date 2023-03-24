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
        static int[] dx = {-1, 0, 1, 0 };
        static int[] dy = {0, 1, 0, -1 };
        static int[,] apart;
        static bool[,] visit;
        static int count = 1;
        static Dictionary<int, int> sorted;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            apart = new int[n, n];
            visit = new bool[n, n];
            for(int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < row.Length; j++)
                {
                    apart[i, j] = int.Parse(row[j].ToString());
                }
            }

            for(int i = 0; i < apart.GetLength(0); i++)
            {
                for(int j = 0; j < apart.GetLength(1); j++)
                {
                    if(apart[i, j] == 1)
                    {
                        bfs(j, i, ++count);
                    }
                }
            }
            sorted = new Dictionary<int, int>();
            foreach(var item in apart)
            {
                if (item == 0)
                    continue;

                if (!sorted.ContainsKey(item))
                    sorted.Add(item, 1);
                else
                    sorted[item] += 1;
            }

            sb.Append(sorted.Count());
            Console.WriteLine(sb);
            var so = sorted.Values.ToList();
            so.Sort();
            so.ForEach(x => { Console.WriteLine(x);});

        }

        static public void bfs(int ox, int oy, int v)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();

          
            q.Enqueue((ox, oy));
            visit[oy, ox] = true;
            apart[oy, ox] = v;
            while(q.Count > 0)
            {
                (int x, int y) = q.Dequeue();
                for(int i = 0; i < 4; i++)
                {
                   int rx = x + dx[i];
                   int ry = y + dy[i];
                    if (rx < 0 || rx >= n || ry < 0 || ry >= n)
                        continue;
                    else if (apart[ry, rx] == 0)
                        continue;
                    else if (visit[ry, rx])
                        continue;
                    else if (apart[ry, rx] == 1)
                    {
                        visit[ry, rx] = true;
                        apart[ry, rx] = count;
                        q.Enqueue((rx, ry));
                    }
                }
            }
        }

    }
}
