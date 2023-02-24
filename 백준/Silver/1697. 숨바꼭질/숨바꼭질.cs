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
            int my;
            int brother;
            bool[] checkpos = new bool[100001];
            int[] pos = Console.ReadLine().Split().Select(int.Parse).ToArray();
            my = pos[0];
            brother = pos[1];

            if (my == brother)
            {
                sb.Append(0);
                Console.WriteLine(sb);
                return;
            }

            Queue<int> q = new Queue<int>();

            checkpos[my] = true;
            q.Enqueue(my);

            int size = q.Count;
            int min = 0;

            while (true)
            {
                min++;
                size = q.Count();
                for (int i = 0; i < size; i++)
                {
                    int x = q.Dequeue();
                    checkpos[x] = true;
                    if (x - 1 == brother || x + 1 == brother || x * 2 == brother)
                    {
                        sb.Append(min);
                        Console.WriteLine(min);
                        return;
                    }
                    if (x - 1 >= 0 && !checkpos[x - 1])
                    {
                        checkpos[x - 1] = true;
                        q.Enqueue(x - 1);
                    }
                    if (x + 1 <= 100000 && !checkpos[x + 1])
                    {
                        checkpos[x + 1] = true;
                        q.Enqueue(x + 1);
                    }
                    if (x * 2 <= 100000 && !checkpos[x * 2])
                    {
                        checkpos[x * 2] = true;
                        q.Enqueue(x * 2);
                    }
                }
            }
        }
    }
}
