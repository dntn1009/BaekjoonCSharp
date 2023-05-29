using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        //9465
        static StringBuilder sb = new StringBuilder();
       
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<(int, string)> list = new List<(int, string)>();

            for(int i = 0; i < n; i++)
            {
                string[] read = Console.ReadLine().Split();
                list.Add((int.Parse(read[0]), read[1]));
            }

            list = list.OrderBy(x => x.Item1).ToList();
            for (int i = 0; i < n; i++)
            {
                sb.Append(list[i].Item1 + " " + list[i].Item2);
                if (i < n - 1)
                    sb.Append("\n");
            }
            Console.WriteLine(sb);

        }
    }
}
