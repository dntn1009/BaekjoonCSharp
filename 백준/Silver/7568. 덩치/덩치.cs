namespace ConsoleApp2
{
        class Size
    {
        int cm;
        int key;
        int rank;

        public int Rank
        { get { return rank; } set{ rank = value; } }
        
        public Size(int _cm, int _key)
        {
            cm = _cm;
            key = _key;
            rank = 0;
        }

        public void CheckRank(Size size)
        {
            if(cm < size.cm && key < size.key)
            {
                rank++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Size[] size;
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
            }
        }


    }
}