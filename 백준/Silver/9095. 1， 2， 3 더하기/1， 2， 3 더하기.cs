using System;
using System.Linq;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

        static int n;
        static int v;
        static int[] value;
        static void Main(string[] args)
        {
            value = new int[11];
            value[0] = 1;
            value[1] = 2;
            value[2] = 4;

            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                v = int.Parse(Console.ReadLine());
                sb.Append(Max());

                if (i != n - 1)
                    sb.Append("\n");
            }

            Console.WriteLine(sb);
        }
   
        public static int Max()
        {
            for(int i = 3; i < v; i++)
            {
                value[i] = value[i - 3] + value[i - 2] + value[i - 1];
            }

            return value[v - 1];
        }
    }
}