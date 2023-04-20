using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int n;
        static int[] order;
        static bool[] visit;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            order = new int[n];
            visit = new bool[n];
            int[] str = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i = 0; i < n; i++)
            {
                int num = str[i];
                int cnt = 0;
                for(int j = 0; j < n; j++)
                {
                    if(!visit[j])
                    {
                        if(cnt == num)
                        {
                            visit[j] = true;
                            order[j] = i + 1;
                            break;
                        }
                        cnt++;
                    }
                }
            }
            for (int i = 0; i < n; i++)
                sb.Append(order[i] + " ");

            Console.WriteLine(sb);

        }

    }
}
