using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int N;
        const int MAX = 101;
        static int[,] input = new int[MAX, MAX];
        static int[,] map = new int[MAX, MAX];
        static bool[,] visited = new bool[MAX, MAX];
        static int[] dy = { 0, 0, -1, 1 };
        static int[] dx = { -1, 1, 0, 0 };
        static Queue<(int, int)> q = new Queue<(int, int)>();
        static int[] v;
        static int cnt = 0; //영역 개수

        static void Main(string[] args)
        {
            int maxHeight = -1;
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int[] read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < N; j++)
                {
                    input[i, j] = read[j];
                    maxHeight = Math.Max(maxHeight, read[j]);
                }
            }
            v = new int[maxHeight];

            for (int h = 1; h <= maxHeight; h++)
            {
                /*h미만 물에 잠김*/

                /*h미만=0 h이상=1 */
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (input[i, j] < h)
                        {
                            map[i, j] = 0;
                        }
                        else
                        {
                            map[i, j] = 1;
                        }
                    }
                }

                /*BFS 영역 개수 구하기*/
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (map[i, j] == 1 && !visited[i, j])
                        {
                            bfs(i, j);
                            cnt++;
                        }
                    }
                }
                v[h - 1] = cnt;
                /*초기화*/
                reset();
            }
            Array.Sort(v);

            sb.Append(v[v.Length - 1]);
            Console.WriteLine(sb);

        }

        static public void bfs(int y, int x)
        {
            visited[y, x] = true;
            q.Enqueue((y, x));

            while (q.Count > 0)
            {
                (y, x) = q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int ny = y + dy[i];
                    int nx = x + dx[i];

                    if (ny < 0 || nx < 0 || ny >= N || nx >= N)
                        continue;
                    if (map[ny, nx] == 1 && !visited[ny, nx])
                    {
                        visited[ny, nx] = true;
                        q.Enqueue((ny, nx));
                    }
                }
            }
        }
        public static void reset()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    map[i, j] = 0;
                    visited[i, j] = false;
                }
            }
            cnt = 0;
        }
    }
}
