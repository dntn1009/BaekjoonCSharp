using System;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(number);

            sb.Append(number[1]);
            Console.WriteLine(sb);
        }
    }
}
