using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05_2022
{
    internal abstract class UF
    {
        private int[] id;
        private int componentNo;
        /// <summary>
        /// Initializare
        /// </summary>
        /// <param name="n"></param>
        public UF(int n)
        {
            id = new int[n];
            componentNo = n;
            for (int i = 0; i < n; i++)
                id[i] = i;
        }
        public abstract int find(int p);
        public abstract bool union(int p, int q);
        
        /// <summary>
        /// Determina daca p si q sunt conectate
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool connected(int p, int q)
        {
            return find(p) == find(q);
        }

        public int count() => componentNo;

    }
}
