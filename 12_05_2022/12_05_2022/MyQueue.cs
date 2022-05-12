using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_2022
{
    public class MyQueue
    {
        #region Fields
        int[] data;
        int capacity;
        int head, tail;
        int count;
        #endregion

        #region Constructors
        public MyQueue() : this(42)
        {
        }
        public MyQueue(int capacity)
        {
            this.capacity = capacity;
            data = new int[capacity];
            head = 0;
            tail = 0;
            count = 0;
        }

        #endregion

        #region Methods
        public void Enqueue(int val)
        {
            if (count < capacity)
            {
                if (tail == data.Length)
                {
                    tail = 0;
                }
                data[tail++] = val;
                count++;
                Logger.Instance.Log($"Am adaugat in coada: {val}");
            }
            else
                throw new QueueFullException("Coada este plina.");
        }
        public int Dequeue()
        {
            if (count > 0)
            {
                int val = data[head];
                head = (head + 1) % capacity;
                count--;
                Logger.Instance.Log($"Am eliminat din coada: {val}");
                return val;
            }
            else throw new QueueEmptyException("Coada este goala.");
        }

        #endregion

        #region Properties
        public int Count => count;
        public bool Empty => count == 0;
        public bool IsFull => head == tail;
        #endregion

    }
}
