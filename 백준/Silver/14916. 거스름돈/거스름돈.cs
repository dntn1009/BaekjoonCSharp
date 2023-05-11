using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        //14916
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 5 == 0)
            {
                sb.Append(n / 5);
            }
            else
            {
                int count = 0;
                bool q = false;
                while (n > 0)
                {
                    n -= 2;
                    count++;
                    if (n % 5 == 0)
                    {
                        q = true;
                        break;
                    }
                }
                if (!q) 
                    sb.Append(-1);
                else
                {
                    count += (n / 5);
                    sb.Append(count);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
