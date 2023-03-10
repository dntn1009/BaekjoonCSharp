using System;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

        static int n;
        static int[] wine;
        static int[] value;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            wine = new int[n + 1];
            value = new int[n + 1];
            for(int i = 1; i <= n; i++)
            {
                wine[i] = int.Parse(Console.ReadLine());
            }

            value[1] = wine[1];
            
            if(n > 1)
                value[2] = wine[1] + wine[2];

            sb.Append(Max(n));

            Console.WriteLine(sb);
        }
     
        public static int Max(int v)
        {
            if (v == 1 || v == 2)
              return value[v];

            for(int i = 3; i <= v; i++)
            {
                int one = wine[i] + value[i - 2];
                int two = wine[i] + wine[i - 1] + value[i - 3];
                int three = value[i - 1];
                value[i] = Math.Max(one, Math.Max(two, three));
             }

            return value[v];
        }
    }
}