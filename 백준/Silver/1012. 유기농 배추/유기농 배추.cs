using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int[] dx = { -1, 0, 1, 0 };
        static int[] dy = { 0, 1, 0, -1 };
        static int T, M, N, K;
        static int[] TA;
        static int[,] Mat;
        static void Main(string[] args)
        {
            T = int.Parse(Console.ReadLine());
            TA = new int[T];

            for(int i = 0; i < T; i++)
            {
                int[] Pos = Console.ReadLine().Split().Select(int.Parse).ToArray();
                M = Pos[0];// 가로
                N = Pos[1];// 세로
                K = Pos[2];

                Mat = new int[N, M];
                Queue<(int, int)> warm = new Queue<(int, int)>();
                while(K > 0)
                {
                    int[] napaPos = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    Mat[napaPos[1], napaPos[0]] = 1;
                    warm.Enqueue((napaPos[0], napaPos[1]));
                    K--;
                }

                while (warm.Count > 0)
                {
                   (int x, int y) = warm.Dequeue();
                    TA[i] += BFS(x, y);
                }
            }
            foreach (int j in TA)
                Console.WriteLine(j);
        }
        public static int BFS(int a, int b)
        {
            bool check = false;
            Queue<(int, int)> warm = new Queue<(int, int)>();

            warm.Enqueue((a, b));

            while(warm.Count > 0)
            {
                (int x, int y) = warm.Dequeue();

                if (Mat[y, x] == 1)
                {
                    Mat[y, x] = 2;
                    check = true;
                }

                for(int i = 0; i < 4; i++)
                {
                    int rx = x + dx[i];
                    int ry = y + dy[i];

                    if (rx < 0 || rx >= M || ry < 0 || ry >= N)
                        continue;
                    else if(Mat[ry, rx] == 0 || Mat[ry, rx] == 2)
                    {
                        continue;
                    }
                    else
                    {
                        check = true;
                        Mat[ry, rx] = 2;
                        warm.Enqueue((rx, ry));
                    }
                }
            }

            if (check)
                return 1;
            else
                return 0;
        }
    }
}

