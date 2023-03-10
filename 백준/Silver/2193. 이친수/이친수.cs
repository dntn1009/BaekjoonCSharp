using System;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

        static int n;
        static long[] value;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            
            value = new long[n + 1];

            value[1] = 1;

            if (n > 1)
                value[2] = 1;

            sb.Append(Max(n));

            Console.WriteLine(sb);
        }
     
        public static long Max(int v)
        {
            if (v == 1 || v == 2)
                return value[v];

            for(int i = 3; i <= v; i++)
            {
                value[i] = value[i - 2] + value[i - 1];
            }
            return value[v];
        }
    }
}
