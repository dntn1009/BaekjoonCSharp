using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            int[] tnum = new int[t];
            for (int i = 0; i < t; i++)
            {
                int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int w = ab[0] % 10;


                if (ab[1] != 1)
                {
                    for (int j = 0; j < ab[1] - 1; j++)
                    {
                        w = (w * ab[0]) % 10;
                    }
                }

                if (w == 0)
                    tnum[i] = 10;
                else
                    tnum[i] = w;

            }

            for (int i = 0; i < t; i++)
            {
                sb.Append(tnum[i]);
                Console.WriteLine(sb);
                sb.Clear();
            }
        }

    }
}
