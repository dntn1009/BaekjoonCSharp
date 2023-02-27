using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp2
{
    public class Meeting
    {
        public int start;
        public int end;

        public Meeting(int _s, int _e)
        {
            start = _s;
            end = _e;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int x = int.Parse(Console.ReadLine());

            Meeting[] meet = new Meeting[x];

            for(int i = 0; i < meet.Length; i++)
            {
                int[] time = Console.ReadLine().Split().Select(int.Parse).ToArray();
                meet[i] = new Meeting(time[0], time[1]);
            }

            var result = meet.OrderBy(i => i.end).ThenBy(i => i.start).Select(i => i).ToArray();

            int count = 0;
            int prev_end = 0;



            for(int i = 0; i < x; i++)
            {
                if (prev_end <= result[i].start)
                {
                    prev_end = result[i].end;
                    count++;
                }
            }

            sb.Append(count);
            Console.WriteLine(sb);
        }

    }
}