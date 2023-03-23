using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        //2422
        //14501
        static StringBuilder sb = new StringBuilder();
        static int n, k;
        static int[] value;
        static int ans = 0;
        static int count = 0;
        static void Main(string[] args)
        {
            int[] read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            n = read[0];
            k = read[1];
            value = new int[n];
            for(int i = 0; i < n; i++)
            {
                value[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(value);
            Min();
            sb.Append(count);
            Console.WriteLine(sb);
        }

        public static void Min()
        {
            if(ans == k)
                return;
            
            for(int i = 0; i < n; i++)
            {
                if (k - ans >= value[i])
                {
                    ans += value[i];
                    count++;
                    break;
                }
            }
            Min();
        }
   
    }
}