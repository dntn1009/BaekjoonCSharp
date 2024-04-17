using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        static StreamReader sr = new StreamReader(Console.OpenStandardInput());

        static void Main(string[] args)
        {
            int n = int.Parse(sr.ReadLine());
            string num = sr.ReadLine();
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(num[i].ToString());
            }
            
            sw.WriteLine(sum.ToString());
            sw.Close();
        }
    }
}