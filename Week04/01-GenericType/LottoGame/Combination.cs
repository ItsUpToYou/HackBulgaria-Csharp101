using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    public class Combination<T,U>
    {

        public T Elem1 { get; private set; }
        public T Elem2 { get; private set; }
        public T Elem3 { get; private set; }
        public U Elem4 { get; private set; }
        public U Elem5 { get; private set; }
        public U Elem6 { get; private set; }

        public Combination(T el1, T el2, T el3, U el4, U el5, U el6)
        {
            this.Elem1 = el1;
            this.Elem2 = el2;
            this.Elem3 = el3;
            this.Elem4 = el4;
            this.Elem5 = el5;
            this.Elem6 = el6;
        }

        public override bool Equals(object obj)
        {
            Combination<T, U> item = obj as Combination<T, U>;

            if (item == null)
            {
                return false;
            }

            return object.Equals(Elem1, item.Elem1) &&
                   object.Equals(Elem2, item.Elem2) &&
                   object.Equals(Elem3, item.Elem3) &&
                   object.Equals(Elem4, item.Elem4) &&
                   object.Equals(Elem5, item.Elem5) &&
                   object.Equals(Elem6, item.Elem6);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
