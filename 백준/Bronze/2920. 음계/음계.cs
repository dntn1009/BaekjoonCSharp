using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        //2512
        static StringBuilder sb = new StringBuilder();
        static int[] value;
        static bool ascend = true, desecnd = true;
        static void Main(string[] args)
        {
            value = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int i = 1; i < value.Length; i++)
            {
                if (value[i - 1] + 1 != value[i])
                    ascend = false;
                if (value[i - 1] - 1 != value[i])
                    desecnd = false;
            }

            if (!ascend && !desecnd)
                sb.Append("mixed");
            else if (!ascend)
                sb.Append("descending");
            else if (!desecnd)
                sb.Append("ascending");

            Console.WriteLine(sb);
        }
    }
}
