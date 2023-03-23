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
        static int n;
        static int[] value;
        static int min = 0;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            value = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(value);
            Min(0);
            sb.Append(min);
            Console.WriteLine(sb);
        }

        public static void Min(int num)
        {
            if(num == n)
                return;

            for(int i = 0; i <= num; i++)
            {
                min += value[i];
            }

            Min(num + 1);

        }
   
    }
}
