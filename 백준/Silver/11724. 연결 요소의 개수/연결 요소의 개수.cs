using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        //11724
        static StringBuilder sb = new StringBuilder();
        static int[,] map;
        static bool[] visited;
        static int n;
        static void Main(string[] args)
        {
            int[] read = Console.ReadLine().Split().Select(int.Parse).ToArray();

            n = read[0];
            int m = read[1];

            map = new int[n + 1, n + 1];
            visited = new bool[n + 1];

            for (int i = 0; i < m; i++)
            {
                int[] UV = Console.ReadLine().Split().Select(int.Parse).ToArray();
                map[UV[0], UV[1]] = 1;
                map[UV[1], UV[0]] = 1;
            }

            int cnt = 0;

            for (int i = 1; i <= n; i++)
            {
                if (!visited[i])
                {
                    bfs(i);
                    cnt++;
                }
            }
            sb.Append(cnt);
            Console.WriteLine(sb);
        }

        static public void bfs(int v)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(v);
            visited[v] = true;


            while (q.Count > 0)
            {
                v = q.Dequeue();

                for (int u = 0; u <= n; u++)
                {
                    if (map[v, u] == 1 && !visited[u])
                    {
                        q.Enqueue(u);
                        visited[u] = true;
                    }
                }
            }
        }
    }
}
