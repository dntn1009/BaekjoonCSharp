using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        public static StreamReader reader = new StreamReader(Console.OpenStandardInput());
        public static StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
        static int[,] mat;
        static int N, M;
        static int[] dx = { 0, 0, 1, -1, 1, 1, -1, -1 };
        static int[] dy = { 1, -1, 0, 0, 1, -1, -1, 1 };
        static bool[,] check;
        static void Main(string[] args)
        {
            
            int[] value = reader.ReadLine().Split(' ').Select(int.Parse).ToArray();
            N = value[0];
            M = value[1];
            mat = new int[N, M];

            for(int i = 0; i < N; i++)
            {
                int[] row = reader.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < M; j++)
                {
                    mat[i, j] = row[j];
                }
            }

            int count = 0;
            int num = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mat[i, j] != 1)
                    {
                        num = bfs(i, j);
                        count = num > count ? num : count;
                    }
                }
            }
            writer.Write(count);
            writer.Close();
        }

        static int bfs(int a, int b)
        {
            check = new bool[N, M];
            Queue<(int, int, int)> q = new Queue<(int, int, int)>();
            q.Enqueue((a, b, 0));
            check[a, b] = true;
            while(q.Count > 0)
            {
                (int rx, int ry, int num) = q.Dequeue();

                for (int i = 0; i < 8; i++)
                {
                    int x = rx + dx[i];
                    int y = ry + dy[i];
                    int z = num + 1;

                    if(x < 0 || x >= N || y < 0 || y >= M || check[x, y] == true) continue;
                    if (mat[x, y] == 1) return z;
                    q.Enqueue((x, y, z));
                    check[x, y] = true;
                }
            }
            return 0;
        }
    }
}
