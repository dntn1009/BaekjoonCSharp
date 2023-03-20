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
            int a = int.Parse(Console.ReadLine());

            if (a >= 90)
                Console.WriteLine("A");
            else if(a >= 80)
                Console.WriteLine("B");
            else if (a >= 70)
                Console.WriteLine("C");
            else if (a >= 60)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
        }
   
    }
}

