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
            //1759

            int[] numsize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int L = numsize[0];
            int C = numsize[1];

            char[] possible = Console.ReadLine().Split().Select(char.Parse).ToArray();

            Array.Sort(possible);

            BF(L, possible, "", 0);


        }
        
        public static bool Check(string password)
        {
            int velow = 0;
            int cons = 0;

            for(int i = 0; i < password.Length; i++)
            {
                if (password[i] == 'a' || password[i] == 'e' || password[i] == 'i' || password[i] == 'o' || password[i] == 'u')
                    velow++;
                else
                    cons++;
            }

            return velow >= 1 && cons >= 2;
        }

        public static void BF(int n, char[] a, string password, int i)
        {
            if(password.Length == n)
            {
                if(Check(password))
                {
                    sb.Append(password);
                    Console.WriteLine(sb);
                    sb.Clear();
                }
                return;
            }

            if(i == a.Length)
            {
                return;
            }

            BF(n, a, password + a[i], i + 1);
            BF(n, a, password, i + 1);
        }
    }
}

