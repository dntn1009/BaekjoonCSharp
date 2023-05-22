using System;
using System.Collections;
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
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
			int start = 0;

			while (n-- > 0)
            {
				int value = int.Parse(Console.ReadLine());

				if (value > start)
				{
					for (int i = start + 1; i <= value; i++)
					{
						stack.Push(i);
						sb.Append("+\n");
					}
					start = value;
				}
				else if (stack.Peek() != value)
				{
					Console.WriteLine("NO");
					return;
				}

				stack.Pop();
				sb.Append("-\n");
			}
			Console.WriteLine(sb);
        }

    }
}
