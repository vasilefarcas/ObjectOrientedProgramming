using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_05_2022
{
    internal class MyQueue
    {
        #region Data
        private int[] data;
        private int left = 0;
        private int right = 0;
        private int count = 0;
        #endregion
        #region Constructors
        public MyQueue(int n)
        {
            this.data = new int[n];

        }
        public MyQueue() : this(42) { }
        public void Enqueu(int n)
        {

        }
        #endregion
        #region Properties
        public bool Empty { get { return count==0; }  }
        public int Count { get { return right - left; } }
        #endregion
        #region Methods
        public void Enqueue(int val)
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
        public int Dequeue()
        {
            if (count > 0)
            {
                int result=data[left];
                left++;
                if (left == data.Length)
                    left = 0;
                count--;
                return result;
            }
            else
                throw new QueueEmptyException("Coada este plina.");
        }
        #endregion
    }
}
