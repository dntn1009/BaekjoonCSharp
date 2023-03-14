using System;
using System.Linq;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

        static int n;
        static int[] v;
        static int[] m;
        static int max = 1;
        static void Main(string[] args)
        {

            n = int.Parse(Console.ReadLine());

            v = Console.ReadLine().Split().Select(int.Parse).ToArray();

            m = new int[v.Length];

            Max();
            sb.Append(max);
            Console.WriteLine(sb);
        }
   
        public static void Max()
        {
            for (int i = 0; i < n; i++)
            {
                m[i] = 1;

                for(int j = 0; j < i; j++)
                {
                    if(v[j] < v[i])
                    {
                        m[i] = Math.Max(m[i], m[j] + 1);
                    }
                }

                max = Math.Max(max, m[i]);
            }
            
        }
    }
}