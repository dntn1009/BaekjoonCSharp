using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{

    class Program
    {

        
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N, M;
            int[,] maze;
            int[] intArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            N = intArr[0];
            M = intArr[1];
            int[] dx = { 0, -1, 0, 1 };
            int[] dy = { -1, 0, 1, 0 };


            maze = new int[N, M];

            for (int i = 0; i < N; i++)
            {

                string row = Console.ReadLine();
                if (row.Length == M)
                {
                    for (int j = 0; j < M; j++)
                    {
                        maze[i, j] = int.Parse(row[j].ToString());
                    }
                }
            }
    
            maze = BFS(maze, dx, dy, N, M);

            sb.Append(maze[N - 1, M - 1]);

            Console.WriteLine(sb);
        }

        public static int[,] BFS(int[,] maze, int[] dx, int[] dy, int N, int M)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue((0, 0)); // Maze 0, 0 부터 돌린다.
            while (q.Count > 0) // 1 ~ 0으로 하나 넣고 빼는 식으로 
            {
                (int x, int y) = q.Dequeue();

                for(int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];
                    if (nx < 0 || ny < 0 || nx >= N || ny >= M || maze[nx, ny] == 0)
                        continue;
                    if(maze[nx, ny] == 1)
                    {
                        maze[nx, ny] = maze[x, y] + 1;
                        q.Enqueue((nx, ny));
                    }
                }
            }
            return maze;
        }

    }
}
