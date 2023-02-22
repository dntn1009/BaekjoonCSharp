using System;
using System.Text;

namespace ConsoleApp3
{
    class CIStack
    {
        int[] _datas;
        int _cnt = 0;

        public CIStack()
        {
            _datas = null;
        }

        public int _capacity
        {
            get { return _datas.Length; }
        }
        public int _isEmpty
        {
            get { if (_cnt == 0)
                    return 1;
                else
                    return 0;
            }
        }

        public int Size()
        {
            return _cnt;
        }
        public void Push(int element)
        {
            if (_cnt == 0)
            {
                _datas = new int[2];
            }
            else
            {
                if (_cnt == _capacity)
                    Array.Resize(ref _datas, _datas.Length * 2);

                for (int i = _cnt - 1; i >= 0; i--)
                {
                    _datas[i + 1] = _datas[i];
                }
            }
            _datas[0] = element;
            _cnt++;
        }

        public int Pop()
        {
            if (_datas == null || _cnt == 0)
            {
                return -1;
            }
            else
            {
                int ret = _datas[0];

                for (int i = 0; i < _cnt - 1; i++)
                {
                    _datas[i] = _datas[i + 1];
                }
                _cnt--;
                return ret;
            }
        }


        public int Top()
        {
            if(_cnt == 0)
                return -1;
            else
            return _datas[0];
        }

        public int this[int index]
        {
            get
            {
                return _datas[index];
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            CIStack stack = new CIStack();
            int num = int.Parse(Console.ReadLine());

            while(num > 0)
            {
                string[] input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "push":
                        stack.Push(int.Parse(input[1]));
                        break;
                    case "top":
                        sb.Append(stack.Top());
                        Console.WriteLine(sb);
                        break;
                    case "size":
                        sb.Append(stack.Size());
                        Console.WriteLine(sb);
                        break;
                    case "empty":
                        sb.Append(stack._isEmpty);
                        Console.WriteLine(sb);
                        break;
                    case "pop":
                        sb.Append(stack.Pop());
                        Console.WriteLine(sb);
                        break;
                }
                sb.Clear();
                num--;
            }
        }
    }
}

