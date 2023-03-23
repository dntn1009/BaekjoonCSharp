using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        //2422
        //14501
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] value = new int[n];

            for (int i = 0; i < n; i++)
            {
                value[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(value);

            for (int i = 0; i < n; i++)
            {
                sb.Append(value[i]);
                if (i != n - 1)
                    sb.Append("\n");
            }
            Console.WriteLine(sb);
        }

   
    }
}