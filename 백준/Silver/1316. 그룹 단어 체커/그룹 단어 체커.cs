using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static bool[] check = new bool[26];
        static int count = 0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                Count(str);
                for (int j = 0; j < check.Length; j++)
                {
                    check[j] = false;
                }
            }

            sb.Append(count);
            Console.WriteLine(sb);
        }
        static int Count(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (check[(str[i] - 'a')])
                {
                    return 0;
                }

                check[(str[i] - 'a')] = true;

                if ((i + 1) < str.Length)
                {
                    while (str[i] == str[i + 1])
                    {
                        i++;
                        if ((i + 1) < str.Length)
                            continue;
                        else
                            break;
                    }
                }
            }
            return count++;
        }
    }
}
