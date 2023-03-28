using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int[] number;
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            number = new int[10];

            for(int i = 0; i < n.Length; i++)
            {
                number[int.Parse(n[i].ToString())]++;
            }

            int count = 0;
            for(int i = 0; i < number.Length; i++)
            {
                if (i != 6 && i != 9)
                    count = Math.Max(count, number[i]);
            }

            sb.Append(Math.Max(count, (number[6] + number[9] + 1) / 2));
            Console.WriteLine(sb);

        }
    }
}
