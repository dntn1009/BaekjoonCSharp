using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static public int[,] mat;
        static public int[] visit;
        static public int N, M, v;
        static void Main(string[] args)
        {
            int[] NMV = Console.ReadLine().Split().Select(int.Parse).ToArray();
            N = NMV[0];
            M = NMV[1];
            v = NMV[2];

            mat = new int[N + 1, N + 1];
            visit = new int[N + 1];
            
            for (int i = 0; i < M; i++)
            {
                int[] dis = Console.ReadLine().Split().Select(int.Parse).ToArray();
                mat[dis[0], dis[1]] = mat[dis[1], dis[0]] = 1;
            }

            dfs(v);
            Console.WriteLine();
            bfs(v);
        }

        public static void dfs(int v)
        {
            sb.Append(v + " ");
            Console.Write(sb);
            sb.Clear();

            visit[v] = 1;

            for(int i = 1; i <= N; i++)
            {
                if (visit[i] == 1 || mat[v, i] == 0)
                    continue;
                dfs(i);
            }
        }

        public static void bfs(int v)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(v);
            visit[v] = 0;

            while(q.Count > 0)
            {
                v = q.Dequeue();
                sb.Append(v + " ");
                Console.Write(sb);
                sb.Clear();
                for(int i = 1; i <= N; i++)
                {
                    if (visit[i] == 0 || mat[v, i] == 0)
                        continue;
                    q.Enqueue(i);
                    visit[i] = 0;
                }
            }

        }
    }
}