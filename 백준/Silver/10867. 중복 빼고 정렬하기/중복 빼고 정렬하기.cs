using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int[] value;
        static bool[] checknumber = new bool[2002];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            value = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(value);

            for (int i = 0; i < n; i++)
            {
                int num;
                if(value[i] < 0)
                {
                    num = value[i] * -1;
                }
                else if(value[i] == 0)
                {
                    num = value[i];
                }
                else
                {
                    num = 1000 + value[i];
                }

                if (!checknumber[num])
                {
                    checknumber[num] = true;
                    sb.Append(value[i] +  " ");
                }
            }
            Console.WriteLine(sb);

        }
    }
}