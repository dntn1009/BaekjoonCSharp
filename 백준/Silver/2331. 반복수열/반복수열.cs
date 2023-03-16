using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int p;
        static int Max = 300001;
        static int[] visited = new int[Max];
        static void Main(string[] args)
        {
            int[] read = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int first = read[0];
            p = read[1];

            dfs(first);

            int result = 0;

            for(int i = 0; i < Max; i++)
            {
                if (visited[i] == 1)
                    result++;
            }

            Console.WriteLine(result);
        }

        public static void dfs(int num)
        {
            visited[num]++;

            if (visited[num] == 3)
                return;
            int sum = 0;

            while(num > 0)
            {
                sum += (int)Math.Pow(num % 10, p);
                num /= 10;
            }

            dfs(sum);
        }
 
    }
}