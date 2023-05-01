using System;
using System.Collections;
using System.Collections.Generic;
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
            int x = read[0];
            int y = read[1];

            ArrayList width = new ArrayList();
            ArrayList height = new ArrayList();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int[] split = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(split[0] == 0)
                    width.Add(split[1]);
                else
                    height.Add(split[1]);
            }

            int maxX = getMaxLen(y, width);
            int maxY = getMaxLen(x, height);

            sb.Append(maxX * maxY);
            Console.WriteLine(sb);
        }
        private static int getMaxLen(int N, ArrayList cuts)
        { // N은 길이, cuts는 점선
            int cutCnt = cuts.Count;
            if (cutCnt == 0)
            { // 한번도 잘리지 않은 경우
                return N;
            }

            cuts.Sort();

            int max = (int)cuts[0]; // 처음 잘린 길이가 우선 제일 크다고 초기화
            for (int i = 1; i < cutCnt; i++)
            { // 첫번째와 두번째 차이, ...
                max = Math.Max(max, (int)cuts[i] - (int)cuts[i - 1]);
            }
            max = Math.Max(max, N - (int)cuts[cutCnt - 1]); // 마지막 잘린 것 길이

            return max;
        }
    }
}
