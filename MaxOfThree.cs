using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    internal class MaxOfThree<T> where T:IComparable
    {
        public T a,b,c;
       public MaxOfThree(T a,T b,T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            
        }

        public T TestMaximun() 
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 ||
                a.CompareTo(b) >= 0 && a.CompareTo(c) > 0 ||
                a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                return a;
            }
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 ||
                b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 ||
                b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                return b;
            }
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0 ||
                c.CompareTo(a) >= 0 && c.CompareTo(b) > 0 ||
                c.CompareTo(a) > 0 && c.CompareTo(b) >= 0)
            {
                return c;
            }
            throw new Exception("a, b, c are same");

        }
    }
}
