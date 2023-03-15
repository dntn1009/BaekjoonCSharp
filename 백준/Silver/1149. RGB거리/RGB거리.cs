using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static int n;
        static int[,] Home;
        static int[] R;
        static int[] G;
        static int[] B;
        static StringBuilder sb = new StringBuilder();
             
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Home = new int[1001 , 3];
            R = new int[n + 1];
            G = new int[n + 1];
            B = new int[n + 1];


            for(int i = 1; i <= n; i++)
            {
                int[] read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Home[i, 0] = read[0] + Math.Min(Home[i - 1, 1], Home[i - 1, 2]);
                Home[i, 1] = read[1] + Math.Min(Home[i - 1, 0], Home[i - 1, 2]);
                Home[i, 2] = read[2] + Math.Min(Home[i - 1, 0], Home[i - 1, 1]);
            }
            sb.Append(Math.Min(Math.Min(Home[n, 0], Home[n, 1]), Home[n, 2]));
            Console.WriteLine(sb);

        }
    }
}
