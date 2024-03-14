using System;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static int[] _value;
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            _value = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // N = (x+1) + (x+2) + ... + (x+L)
            // N = Lx + L(L+1) / 2
            // Lx = N - L(L+1) / 2
            // Lx / L = (N - L(L+1) / 2) / L
            // x = (N - L(L+1) / 2) / L   => x가 정수가 됩니다.

            int index = _value[1];
            int x;

            while (true)
            {
                x = _value[0] - index * (index + 1) / 2;

                if(x % index == 0)
                {
                    x /= index;

                    if(x >= - 1)
                    {
                        for(int i = 1; i < index + 1; i++)
                        {
                            sb.Append(x + i);

                            if (i <index + 1)
                                sb.Append(" ");
                        }
                        break;
                    }
                }

                if(index >= 100)
                {
                    sb.Append("-1");
                    break;
                }

                index++;

            }

            Console.WriteLine(sb);
        }
    }
}