using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        static int[] Visit = Enumerable.Repeat<int>(-1, 100001).ToArray<int>();

        static int n, k;
        static void Main(string[] args)
        {
            // 입력 받기
            int[] input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            n = input[0];
            k = input[1];

            sw.WriteLine(Serach(n, k).ToString());
            sw.Close();
        }

        static public int Serach(int n, int k)
        {
            Queue<int> q = new Queue<int>();
            int start = n;
            Visit[start] = 0;

            q.Enqueue(start);

            while(q.Count > 0)
            {
                int search = q.Dequeue();

                if (k == search)
                    return Visit[search];

                if (search * 2 < 100001)
                {
                    if (Visit[search * 2] == -1)
                    {
                        Visit[search * 2] = Visit[search];
                        q.Enqueue(search * 2);
                    }
                    else
                    {
                        if (Visit[search * 2] > Visit[search])
                            Visit[search * 2] = Visit[search];
                    }

                }

                if (search - 1 >= 0 && Visit[search - 1] == -1)
                {
                    Visit[search - 1] = Visit[search] + 1;
                    q.Enqueue(search - 1);
                }

                if (search + 1 < 100001 && Visit[search + 1] == -1)
                {
                    Visit[search + 1] = Visit[search] + 1;
                    q.Enqueue(search + 1);
                }
            }
            return -1;
        }
    }
}
