using System;
using System.Linq;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int[] number;
        static void Main(string[] args)
        {
            int[] read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            number = new int[read[1] + 1];
            int min = read[0];
            int max = read[1];

            number[0] = 1;
            number[1] = 1;

            for (int i = 2; i <= max; i++)
            {
                for (int j = 2 * i; j <= max; j += i)
                {
                    if (number[j] == 0)
                        number[j] = 1;
                }
            }

            for (int i = min; i <= max; i++)
            {
                if (number[i] == 0)
                {
                    sb.Append(i + "\n");
                }
            }

            Console.Write(sb);
        }
    }
}
