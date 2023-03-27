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
            string last = "-1";
            Queue<int> q = new Queue<int>();
            for(int i = 0; i < n; i++)
            {
                string[] Input = Console.ReadLine().Split();
                if(Input.Length == 2)
                    last = Input[1];

                switch(Input[0])
                {
                    case "push":
                        q.Enqueue(int.Parse(Input[1]));
                        break;
                    case "front":
                        if (q.Count == 0)
                            sb.Append(-1);
                        else
                         sb.Append(q.Peek());
                        break;
                    case "pop":
                        if (q.Count == 0)
                            sb.Append(-1);
                        else
                            sb.Append(q.Dequeue());
                        break;
                    case "size":
                        sb.Append(q.Count);
                        break;
                    case "empty":
                        if (q.Count != 0)
                            sb.Append(0);
                        else
                            sb.Append(1);
                        break;
                    case "back":
                        if (q.Count == 0)
                            sb.Append(-1);
                        else
                            sb.Append(last);
                        break;

                }

                if (i != n - 1 && !Input[0].Equals("push"))
                    sb.Append("\n");
            }
            Console.WriteLine(sb);
        }

    }
}