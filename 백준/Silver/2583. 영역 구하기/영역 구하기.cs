using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int m, n, k;
        //static int[,] input;
        static int[,] map;
        static bool[,] visited;
        static int[] dy = { 0, 0, -1, 1 };
        static int[] dx = { -1, 1, 0, 0 };
        static Queue<(int, int)> q = new Queue<(int, int)>();
        static int[] v;
        static int cnt = 0; //영역 개수
        static ArrayList area = new ArrayList();
        static void Main(string[] args)
        {
            int[] read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            m = read[0];
            n = read[1];
            k = read[2];
            map = new int[m, n];
            visited = new bool[m, n];

            for (int i = 0; i < k; i++)
            {
                int[] coord = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int y = coord[1]; y < coord[3]; y++)
                {
                    for (int x = coord[0]; x < coord[2]; x++)
                    {
                        map[y, x] = 1;
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (map[i, j] == 0 && !visited[i, j])
                    {
                        area.Add(bfs(i, j));
                        cnt++;
                    }
                }
            }
            area.Sort();
            sb.Append(cnt + "\n");

            for(int i = 0; i < area.Count; i++)
            {
                sb.Append(area[i]);
                if (i != area.Count - 1)
                    sb.Append(" ");
            }
            Console.WriteLine(sb);

        }

        public static int bfs(int y, int x)
        {
            int area = 1;
            visited[y, x] = true;
            q.Enqueue((y, x));

            while (q.Count > 0)
            {
                (y, x) = q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int ny = y + dy[i];
                    int nx = x + dx[i];

                    if (ny < 0 || nx < 0 || ny >= m || nx >= n)
                        continue;
                    if (map[ny, nx] == 0 && !visited[ny, nx])
                    {
                        visited[ny, nx] = true;
                        q.Enqueue((ny, nx));
                        area++;
                    }
                }
            }

            return area;
        }

    }
}
