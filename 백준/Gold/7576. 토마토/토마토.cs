using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Queue<(int, int)> q = new Queue<(int, int)>();
            int n, m;
            int[,] box;
            int[] dx = {-1, 0, 1, 0 };
            int[] dy = { 0, -1, 0, 1};
            int[] Maxpos = Console.ReadLine().Split().Select(int.Parse).ToArray();
            n = Maxpos[1];
            m = Maxpos[0];

            box = new int[n, m];

            bool check = true;


            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j = 0; j < m; j++)
                {
                    box[i, j] = row[j];
                    if (row[j] == 1)
                        q.Enqueue((i, j));
                    else if (row[j] == 0)
                        check = false;
                }
            }

            if(check)
            {
                sb.Append(0);
                Console.WriteLine(sb);
                return;
            }

            int count = 0;

            while(q.Count > 0)
            {
                count++;
                int size = q.Count();

                for(int i = 0; i < size; i++)
                {
                    (int x, int y) = q.Dequeue();

                    for (int j = 0; j < 4; j++)
                    {
                        int nx = x + dx[j];
                        int ny = y + dy[j];

                            if (nx >= 0 && nx < n && ny >= 0 && ny < m && box[nx, ny] != 1 && box[nx, ny] != -1)
                            {
                                box[nx, ny] = 1;
                                q.Enqueue((nx, ny));
                            }
                    }
                }
            }
            count--;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (box[i, j] == 0)
                        count = -1;
                }
            }

            sb.Append(count);
            Console.WriteLine(sb);
        }

    }
}
