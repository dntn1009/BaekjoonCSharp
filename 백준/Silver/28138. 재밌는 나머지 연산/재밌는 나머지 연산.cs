using System;
using System.IO;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        static long N, R;
        static void Main(string[] args)
        {
            sw.AutoFlush = true;

            string[] input = sr.ReadLine().Split();
            long N = long.Parse(input[0]);
            long R = long.Parse(input[1]);

            long value = N - R;
            long sum = 0;
            long sqrtValue = (long)Math.Sqrt(value);
            for (long i = 1; i* i < value; i++)
            {
                if (value % i == 0)
                {
                    if (i > R)
                        sum += i;
                    if (value / i > R)
                        sum += value / i;
                }
            }

            if (sqrtValue * sqrtValue == value && sqrtValue > R)
                sum += sqrtValue;

            sw.WriteLine(sum.ToString());
            sw.Flush();
            sr.Close();
            sw.Close();
            
        }
    }

}
