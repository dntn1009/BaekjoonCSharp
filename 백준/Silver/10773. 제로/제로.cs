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
            Stack<int> s = new Stack<int>();
            for(int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value == 0)
                {
                    if (s.Count != 0)
                        s.Pop();
                }
                else
                    s.Push(value);
            }
            int count = 0;
            int length = s.Count;
            if (length != 0)
                for(int i = 0; i < length; i++)
                {
                    count += s.Pop();
                }
            sb.Append(count);
            Console.WriteLine(sb);

        }
    }
}