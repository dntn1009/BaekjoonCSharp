using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                q.Enqueue(i);
            }

            while(q.Count > 1)
            {
                sb.Append(q.Dequeue() + " ");
                q.Enqueue(q.Dequeue());
            }

            sb.Append(q.Dequeue());
            Console.WriteLine(sb);
        }

    }
}
