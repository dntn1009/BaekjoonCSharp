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
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            (int x, int y)[] arr = new (int x, int y)[n];

            for (int i = 0; i < n; i++)
            {
                int[] read = Console.ReadLine().Split().Select(int.Parse).ToArray();

                arr[i] = (read[0], read[1]);
            }

            Array.Sort(arr);

            for(int i = 0; i < n; i++)
            {
                sb.Append(arr[i].x + " " + arr[i].y);

                if (i != n - 1)
                    sb.Append("\n");
            }
            Console.WriteLine(sb);
        }

    }
}
