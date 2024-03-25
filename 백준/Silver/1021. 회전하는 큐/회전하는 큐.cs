using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            string[] input = reader.ReadLine().Split();
            string[] input2 = reader.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            List<int> m = new List<int>();
            for (int i = 0; i < input2.Length; i++)
                m.Add(int.Parse(input2[i]));

            List<int> dequeue = new List<int>();

            for (int i = 1; i <= N; i++)
                dequeue.Add(i);

            int count = 0;

            for (int i = 0; i < M; i++)
            {
                int index = dequeue.FindIndex(o => o == m[0]); // 찾고자 하는 수의 인덱스
                if (index <= dequeue.Count / 2) // 총 카운트/2 보다 작으면 2번 실행 크면 3번실행
                {
                    for (int j = 0; j < index; j++) // 2번
                    {
                        int temp = dequeue[0];
                        dequeue.RemoveAt(0); // 왼쪽을 제거
                        dequeue.Add(temp); // 맨 오른쪽으로 이동
                        count++; // 카운트 갱신
                    }
                    dequeue.RemoveAt(0); // 해당 값을 찾아서 제거
                    m.RemoveAt(0); // 찾을 값을 제거
                }
                else
                {
                    for (int j = 0; j < dequeue.Count - index; j++) // 3번
                    {
                        int temp = dequeue[^1];
                        dequeue.RemoveAt(dequeue.Count - 1); // 맨 끝 오른쪽 값을 제거
                        dequeue.Insert(0, temp); // 맨 처음에 값을 삽입
                        count++; // 카운트 갱신
                    }
                    dequeue.RemoveAt(0);
                    m.RemoveAt(0);
                }
            }

            writer.WriteLine(count);

            writer.Close();
            reader.Close();

        }
    }
}
