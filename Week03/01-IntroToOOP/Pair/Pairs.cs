namespace Pair
{
    public class Pairs
    {
        //properties
        public object f1 { get;  set; }
        public object f2 { get;  set; }

        //Constructor
        public Pairs(object f1, object f2)
        {
            this.f1 = f1;
            this.f2 = f2;
        }

        //Override ToString
        public override string ToString()
        {
            string format = string.Format("{0}, {1}", f1, f2);
            return format;
        }

        //Override Equals
        public override bool Equals(object obj)
        {
            Pairs item = obj as Pairs;
            if ((item.f1.Equals(this.f1)) && (item.f2.Equals(this.f2)))
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Pairs f1, Pairs f2)
        {
            if (f1.Equals(f2))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Pairs f1, Pairs f2)
        {
            if (!f1.Equals(f2))
            {
                return true;
            }
            return false;
        }

        //GethashCode
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + f1.GetHashCode();
                hash = hash * 23 + f2.GetHashCode();
                return hash;
            }
        }
    }
}
