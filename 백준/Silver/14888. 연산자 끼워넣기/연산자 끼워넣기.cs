using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int MAX = int.MinValue;
        static int MIN = int.MaxValue;
        static int[] oper = new int[4];
        static int[] number;
        static int n;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            number = Console.ReadLine().Split().Select(int.Parse).ToArray();


            oper = Console.ReadLine().Split().Select(int.Parse).ToArray();
            dfs(number[0], 1);

            sb.Append(MAX + "\n" + MIN);
            Console.WriteLine(sb);
        }

        public static void dfs(int num, int idx)
        {
            if(idx == n)
            {
                MAX = Math.Max(MAX, num);
                MIN = Math.Min(MIN, num);
                return;
            }

            for(int i = 0; i < 4; i++)
            {
                if(oper[i] > 0)
                {
                    oper[i]--;

                    switch (i)
                    {
                        case 0:
                            dfs(num + number[idx], idx + 1);
                            break;
                        case 1:
                            dfs(num - number[idx], idx + 1);
                            break;
                        case 2:
                            dfs(num * number[idx], idx + 1);
                            break;
                        case 3:
                            dfs(num / number[idx], idx + 1);
                            break;
                    }

                    oper[i]++;
                }
            }
        }

    }
}
