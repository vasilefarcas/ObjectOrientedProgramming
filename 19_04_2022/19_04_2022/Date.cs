using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_04_2022
{
    internal class Date
    {
        int zi;
        int luna;
        int an;
        public int Zi => zi;
        public int Luna => luna;
        public int An => an;
        public Date(int zi, int luna, int an)
        {
            this.zi = zi;
            this.luna = luna;
            this.an = an;
        }
        public Date(string s)
        {
            string[] token = s.Split(new char[] { ' ', '/', '-' }, StringSplitOptions.RemoveEmptyEntries);
            zi = int.Parse(token[0]);
            luna = int.Parse(token[1]);
            an = int.Parse(token[2]);
        }
        public Date() : this(1, 1, 1990)
        {

        }
        public override string ToString()
        {
            return $"{zi}/{luna}/{an}";
        }
        public int CompareTo(Date other)
        {
            if (other == null)
                return 1;
            if (this.an < other.an)
                return -1;
            else
            if (this.an > other.an)
                return 1;
            else if (this.luna < other.luna)
                return -1;
            else if (this.luna > other.luna)
                return 1;
            else if (this.zi < other.zi)
                return -1;
            else if (this.zi > other.zi)
                return 1;
            return 0;
        }
        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            if (obj == null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            Date other = obj as Date;
            return (this.an == other.an) && (this.luna == other.luna) && (this.zi == other.zi);
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + this.zi;
            hash = hash * 31 + this.luna;
            hash = hash * 31 + this.an;
            return hash;
        }

        public bool Verify()
        {
            if (this == null)
                return false;
            if (this.luna < 1 || this.luna > 12)
                return false;
            int[] numar_zile = new int[13] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (this.zi < 1 || this.zi > numar_zile[luna])
                return false;
            return true;
        }
    }
}
