using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        static int N;
        static void Main(string[] args)
        {
            N = int.Parse(sr.ReadLine());
            PriorityQueue<long> q = new PriorityQueue<long>();
            for(int i = 0; i < N; i++)
            {
                q.Enqueue(long.Parse(sr.ReadLine()));
            }

            long sum = 0;

            while(q.Count > 1)
            {
                long x = q.Dequeue();
                long y = q.Dequeue();

                sum += x + y;
                q.Enqueue(x + y);
            }

            sw.Write(sum.ToString());
            sw.Close();
        }
    }

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;

        public int Count { get { return data.Count; } }

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            int ci = data.Count - 1; // child index; start at end
            while (ci > 0)
            {
                int pi = (ci - 1) / 2; // parent index
                if (data[ci].CompareTo(data[pi]) >= 0) break; // child item is larger than (or equal) parent so we're done
                T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
                ci = pi;
            }
        }

        public T Dequeue()
        {
            // assumes pq is not empty; up to calling code
            int li = data.Count - 1; // last index (before removal)
            T frontItem = data[0];   // fetch the front
            data[0] = data[li];
            data.RemoveAt(li);

            --li; // last index (after removal)
            int pi = 0; // parent index. start at front of pq
            while (true)
            {
                int ci = pi * 2 + 1; // left child index of parent
                if (ci > li) break;  // no children so done
                int rc = ci + 1;     // right child
                if (rc <= li && data[rc].CompareTo(data[ci]) < 0) // if there is a rc (ci + 1), and it is smaller than left child, use the rc instead
                    ci = rc;
                if (data[pi].CompareTo(data[ci]) <= 0) break; // parent is smaller than (or equal to) smallest child so done
                T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp; // swap parent and child
                pi = ci;
            }
            return frontItem;
        }
    }


}
