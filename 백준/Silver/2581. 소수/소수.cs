using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int min = -1;
            int plus = 0;

            for(int i = M; i <= N; i++)
            {
                int cnt = 0;
                for(int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                        cnt++;
                }

                if(cnt == 2)
                {
                    if (min == -1)
                        min = i;
                    plus += i;
                }
            }

            if (min != -1)
            {
                sb.Append(plus);
                Console.WriteLine(sb);
            }
            sb.Clear();
            sb.Append(min);
            Console.WriteLine(sb);
        }
    }
}
