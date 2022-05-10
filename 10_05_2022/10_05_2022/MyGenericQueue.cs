using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_05_2022
{
    internal class MyGenericQueue<T>
    {
        #region Data
        private T[] data;
        private int left = 0;
        private int right = 0;
        private int count = 0;
        #endregion
        #region Constructors
        public MyGenericQueue(int n)
        {
            this.data = new T[n];

        }
        public MyGenericQueue() : this(42) { }
        public void Enqueu(T val)
        {

        }
        #endregion
        #region Properties
        public bool Empty { get { return count == 0; } }
        public int Count { get { return right - left; } }
        #endregion
        #region Methods
        public void Enqueue(T val)
        {
            if (count < data.Length)
            {
                if (right < data.Length)
                { data[right++] = val; }
                else
                {
                    data[0] = val;
                    right = 1;
                }
                count++;
            }
            else throw new QueueFullException("Coada este plina.");
        }
        public T Dequeue()
        {
            if (count > 0)
            {
                T result = data[left];
                left = (left + 1) % data.Length;
                count--;
                return result;
            }
            else
            {
                throw new QueueEmptyException("Coada este goala.");
            }
        }
        #endregion
    }
}
