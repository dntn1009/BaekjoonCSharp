using System;
using System.Linq;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            #region ejdcl
            /*  Size[] size;
              int num;

              while (true)
              {
                  num = int.Parse(Console.ReadLine());

                  if (num >= 2 && num <= 50)
                      break;
                  else
                      Console.WriteLine("2 보다 크거나 같고 50보다 작거나 같아야합니다.");
              }

              size = new Size[num];
              for(int i = 0; i < num; i++)
              {
                  string info = Console.ReadLine();
                  string[] splitInfo;
                  while (true)
                  {
                      splitInfo = info.Split(' ');

                      int x = int.Parse(splitInfo[0]);
                      int y = int.Parse(splitInfo[1]);
                      if (x >= 10 && x <= 200 && y >= 10 && y <= 200)
                          break;
                      else
                          Console.WriteLine("10보다 크거나 같고 200보다 작거나 같아야합니다.");
                  }

                  size[i] = new Size(int.Parse(splitInfo[0]), int.Parse(splitInfo[1]));
              }

              for(int i = 0; i < size.Length; i++)
              {
                 for(int j = 0; j < size.Length; j++)
                  {
                      size[i].CheckRank(size[j]);
                  }
                  size[i].Rank ++;
              }

              for(int i = 0; i < size.Length; i++)
              {
                  Console.Write("{0} ", size[i].Rank);
              }*/
            #endregion

            int N, K;
            int[] Sensor_Dis; // 센서 위치
            int[] Min_Distance; // 센서의 위츠를 계산한 거리

            while (true)
            {
                N = int.Parse(Console.ReadLine());
                if (N >= 1 && N <= 10000)
                    break;
                else
                    Console.WriteLine("1보다 크거나 같아야하고 10000보다 작거나 같아야 합니다.");
            }

            while (true)
            {
                K = int.Parse(Console.ReadLine());
                if (K >= 1 && K <= 10000)
                    break;
                else
                    Console.WriteLine("1보다 크거나 같아야하고 10000보다 작거나 같아야 합니다.");
            }

            while (true)
            {
                Sensor_Dis = Console.ReadLine().Split().Select(int.Parse).ToArray();
                // using System.Linq => Select 이용하여 String -> int로 변경

                if (Sensor_Dis.Length == N)
                    break;
                else
                    Console.WriteLine("N개의 수만큼 입력해 주세요.");
            }

            Array.Sort(Sensor_Dis);
            // 오름차순으로 정렬

            Min_Distance = new int[N - 1];

            for(int i = 0; i < N - 1; i++)
            {
                Min_Distance[i] = Sensor_Dis[i + 1] - Sensor_Dis[i];
            }
            
            Array.Sort(Min_Distance, (a, b) => b.CompareTo(a));
            // Sort(int[], Comparison) Comparison => 숫자 비교
            //                                   람다식 비교로 내림차순 정렬(거리 차이)

            int sum = 0;

            //가장 긴거리부터 K - 1 까지 더함.
            for (int i = 0; i < K - 1 && i < N - 1; i++)
            {
                sum += Min_Distance[i];
            }

            int finish = Sensor_Dis[N - 1] - Sensor_Dis[0] - sum;
            Console.WriteLine("{0}", finish);


        }


    }
}
