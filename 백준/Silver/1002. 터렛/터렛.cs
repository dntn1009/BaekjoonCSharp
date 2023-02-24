using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(Console.ReadLine());
            int[] tnum = new int [t];
            for (int i = 0; i < t; i++)
            {
                int[] mPos = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int jx = mPos[0];
                int jy = mPos[1];
                int jDis = mPos[2];
                int bx = mPos[3];
                int by = mPos[4];
                int bDis = mPos[5];

                
                int jbdis = (int)Math.Pow(bx - jx, 2) + (int)Math.Pow(by - jy, 2);
                if (jx == bx && jy == by && jDis == bDis)
                {
                    tnum[i] = -1;
                }
                else if (jbdis < Math.Pow(bDis - jDis, 2) || jbdis > Math.Pow(bDis + jDis, 2))
                {
                    tnum[i] = 0;
                }
                else if (jbdis == Math.Pow(bDis - jDis, 2) || jbdis == Math.Pow(bDis + jDis, 2))
                {
                    tnum[i] = 1;
                }
                else
                    tnum[i] = 2;
            }

            for(int i = 0; i < t; i++)
            {
                sb.Append(tnum[i]);
                Console.WriteLine(sb);
                sb.Clear();
            }

        }

    }
}
