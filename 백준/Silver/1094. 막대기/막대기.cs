using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int count = 0;
            int stick = 64;

            int x = int.Parse(Console.ReadLine());

            while(x > 0)
            {
                if (stick > x) 
                    stick /= 2;
                else
                {
                    count++;
                    x -= stick;
                }

            }
            sb.Append(count);
            Console.WriteLine(sb);
        }

    }
}