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
            int[] read = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int a = read[0];
            int b = read[1];
            int c = read[2];

            int one = (a + b) % c;
            int two = ((a % c) + (b % c)) % c;
            int three = (a * b) % c;
            int four = ((a % c) * (b % c)) % c;

            sb.Append(one + "\n" + two + "\n" + three + "\n" + four);
            Console.WriteLine(sb);
        }
   
    }
}