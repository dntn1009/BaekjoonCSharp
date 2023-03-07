using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int[] dx = { -1, 0, 1, 0 };
        static int[] dy = { 0, -1, 0, 1 };
        static int N;
        static char[,] Mat;
        static bool[,] avisit;

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            Mat = new char[N, N];
            avisit = new bool[N, N];
            for(int i = 0; i < N; i++)
            {
                string row = Console.ReadLine();

                for(int j = 0; j < N; j++)
                {
                    Mat[i, j] = row[j];
                }
            }

            int acount = 0;
            int bcount = 0;
            while (!avisit[N - 1, N - 1])
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if(!avisit[i, j])
                        acount += aBFS(i, j);
                    }
                }
            }

            while (avisit[N - 1, N - 1])
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (avisit[i, j])
                            bcount += bBFS(i, j);
                    }
                }
            }

            sb.Append(acount + " " + bcount);
            Console.WriteLine(sb);
        }
        
        public static int aBFS(int a, int b)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();

            q.Enqueue((b, a));
            avisit[a, b] = true;
            while(q.Count > 0)
            {
                (int x, int y) = q.Dequeue();

                char c = Mat[y, x];

                for(int i = 0; i < 4; i++)
                {
                    int rx = x + dx[i];
                    int ry = y + dy[i];

                    if (rx < 0 || rx >= N || ry < 0 || ry >= N || avisit[ry, rx])
                        continue;
                    else if(c.Equals(Mat[ry, rx]) && !avisit[ry, rx])
                    {
                        avisit[ry, rx] = true;
                        q.Enqueue((rx, ry));
                    }
                }
            }
            return 1;
        }
        public static int bBFS(int a, int b)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();

            q.Enqueue((b, a));
            avisit[a, b] = false;

            if (Mat[a, b] == 'R')
                 Mat[a, b] = 'G';

            while (q.Count > 0)
            {
                (int x, int y) = q.Dequeue();

                char c = Mat[y, x];

                for (int i = 0; i < 4; i++)
                {
                    int rx = x + dx[i];
                    int ry = y + dy[i];

                    if(rx >= 0 && rx < N && ry >=0 && ry < N && Mat[ry, rx] == 'R')
                            Mat[ry, rx] = 'G';

                    if (rx < 0 || rx >= N || ry < 0 || ry >= N || !avisit[ry, rx])
                    {
                        continue;
                    }
                    else if (c.Equals(Mat[ry, rx]) && avisit[ry, rx])
                    {
                        avisit[ry, rx] = false;
                        q.Enqueue((rx, ry));
                    }
                }
            }
            return 1;
        }
    }
}
