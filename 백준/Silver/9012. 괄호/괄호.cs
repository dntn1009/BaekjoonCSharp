using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int n;
        static void Main(string[] args)
        {
            //1913
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                int left = 0;
                int right = 0;
                for(int j = 0; j < str.Length; j++)
                {
                    if (str[j].Equals('('))
                        left++;
                    else
                        right++;

                    if(right > left)
                    {
                        sb.Append("NO\n");
                        break;
                    }

                    if(j == str.Length - 1)
                    {
                        if (left == right)
                            sb.Append("YES\n");
                        else
                            sb.Append("NO\n");
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}
