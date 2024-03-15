using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        static int[,] _matrix;
        static StringBuilder sb = new StringBuilder();
        static int[] _value;
        static int _count;
        int _k;
        static void Main(string[] args)
        {
            _value = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            _matrix = new int[_value[0], _value[1]];

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                string strnum = Console.ReadLine();

                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    _matrix[i, j] = int.Parse(strnum[j].ToString());
                }
            }

            int k = int.Parse(Console.ReadLine());
            // 정보 입력

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {

                int zeroCount = 0;

                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    if (_matrix[i, j] == 0) zeroCount++;
                }

                int samePattern = 0;

                if (zeroCount <= k && zeroCount % 2 == k % 2)
                {
                    for (int j = 0; j < _matrix.GetLength(0); j++)
                    {
                        if (isSame(_matrix, i, j, _matrix.GetLength(1))) samePattern++;
                    }
                }
                _count = Math.Max(_count, samePattern);
            }

            sb.Append(_count);
            Console.WriteLine(sb);
        }
        public static bool isSame(int[,] matrix, int me, int target, int m)
        {
            for(int i = 0; i < m; i++)
            {
                if (matrix[me, i] != matrix[target, i])
                    return false;
            }
            return true;
        }
    }
}
