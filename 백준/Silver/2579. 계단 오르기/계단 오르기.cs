using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int T;
        static int[] stairs;
        static int[] Maxvalue;
        static void Main(string[] args)
        {
            T = int.Parse(Console.ReadLine());
            stairs = new int[T + 1];
            Maxvalue = new int[T + 1];
            for(int i = 1; i <= T; i++)
            {
                stairs[i] = int.Parse(Console.ReadLine());
            }

            Maxvalue[1] = stairs[1];
            
            if(T > 1)
            {
                Maxvalue[2] = stairs[1] + stairs[2];
            }

            sb.Append(max(T));

            Console.WriteLine(sb);
        }
        
        static int max(int a)
        {
            if(a == 1 || a == 2)
            {
                return Maxvalue[a];
            }
            else
            {
                for(int i = 3; i <= a; i++)
                {
                    var one = Maxvalue[i - 2] + stairs[i];
                    var two = Maxvalue[i - 3] + stairs[i - 1] + stairs[i];
                    Maxvalue[i] = Math.Max(one, two);
                }
                return Maxvalue[a];
            }
        }
    }
}