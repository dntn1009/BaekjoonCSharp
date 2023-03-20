using System;
using System.Linq;
using System.Text;


namespace ConsoleApp3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

  
        static void Main(string[] args)
        {
            int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();

            sb.Append(ab[0] - ab[1]);
            Console.WriteLine(sb);
        }
   
    }
}

