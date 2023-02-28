using System;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static int virus = 0;
        static void dfs(int v, int[,] link, bool[] visited)
        {
            if (visited[v]) return;

            visited[v] = true;

            for(int i = 0; i < link.GetLength(0); i++)
            {
                if(!visited[i] && link[v, i] == 1)
                {
                    virus++;
                    dfs(i, link, visited);
                }
            }
        }

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int computer = int.Parse(Console.ReadLine());
            int network = int.Parse(Console.ReadLine());

            int[,] link = new int[computer + 1, computer + 1];

            for(int i = 0; i < network; i++)
            {
                int[] _con = Console.ReadLine().Split().Select(int.Parse).ToArray();
                link[_con[0], _con[1]] = link[_con[1], _con[0]] = 1;
            }

            bool[] visited = new bool[computer + 1];

            dfs(1, link, visited);

            sb.Append(virus);
            Console.WriteLine(sb);
        }

    }
}