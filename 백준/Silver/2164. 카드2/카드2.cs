using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
     
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            for(int i = 1; i <=n; i++)
            {
                q.Enqueue(i);
            }

            while(q.Count > 1)
            {
                q.Dequeue();
                if (q.Count == 1)
                    break;
                else
                {
                    q.Enqueue(q.Dequeue());
                }
            }
            int value = q.Dequeue();
            sb.Append(value);
            Console.WriteLine(sb);
        }
    }
}
