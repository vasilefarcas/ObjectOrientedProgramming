using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_03_2022
{
    internal class MyStack
    {
        private int[] data;
        private int _capacity = 16;
        private int _count = 0;
        public bool IsEmpty
        {
            get { return _count == 0; }
        }
        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public MyStack()
        {
            data = new int[_capacity];

        }
        public int Count
        {
            get { return _count; }
        }
        internal void Push(int n)
        {
            if (_count < _capacity)
            {
                data[_count] = n;
            }
            else
            {
                _capacity *= 2;
                int[] vs = new int[_capacity];
                for (int i = 0; i < _count; i++)
                    vs[i] = data[i];
                data = vs;
            }
            _count++;
        }
        internal int Pop()
        {
            if (_count > 0)
            {
                _count--;
                return data[_count];
            }
            else throw new StackEmptyException("S-a incercat eliminarea unui element dintr-o stiva goala.");
        }
        internal int Peek()
        {
            if (IsEmpty)
                throw new StackEmptyException("Nu exista elemente in aceasta stiva.");
            return data[_count - 1];
        }
    }
}
