using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    

    class Vector
    {
        private int[] coords;

        public Vector(params int[] coords)
        {
            this.coords = coords;
        }
        public Vector(Vector vector)
        {
            coords = new int[vector.coords.Length];
            for (int i = 0; i < vector.coords.Length; i++)
            {
                coords[i] = vector.coords[i];
            }
        }
        public int this[int index]
        {
            get { return coords[index]; }
            set { coords[index] = value; }
        }
        public int GetDimension
        {
            get { return coords.Length; }
        }
        public double GetLenght()
        {
            double lenght = 0;
            for (int i = 0; i < coords.Length; i++)
            {
                lenght += Math.Pow(coords[i], 2);
            }
            return Math.Sqrt(lenght);

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < coords.Length; i++)
            {
                sb.Append(coords[i] + " ");
            }
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {

            Vector vect = (Vector)obj;
            if (this.coords.Length != vect.coords.Length)
            {
                return false;
            }
            for (int i = 0; i < coords.Length; i++)
            {
                if (!vect[i].Equals(this.coords[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator ==(Vector one, Vector two)
        {
            if (one.Equals(two))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Vector one, Vector two)
        {
            if (!one.Equals(two))
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + coords.Length;
                return hash;
            }
        }
        public static Vector operator +(Vector one, Vector two)
        {
            if (one.coords.Length != two.coords.Length)
            {
                throw new Exception("Lenght of the two vectors is diffrent");
            }
            Vector sum = new Vector(one);
            for (int i = 0; i < one.coords.Length; i++)
            {
                sum[i] = one.coords[i] + two.coords[i];
            }
            return sum;
        }
        public static Vector operator -(Vector one, Vector two)
        {
            if (one.coords.Length != two.coords.Length)
            {
                throw new Exception("Lenght of the two vectors is diffrent");
            }
            Vector diff = new Vector(one);
            for (int i = 0; i < diff.coords.Length; i++)
            {
                diff[i] = one.coords[i] - two.coords[i];
            }
            return diff;
        }
        public static Vector operator +(Vector vect, int scalar)
        {
            for (int i = 0; i < vect.coords.Length; i++)
            {
                vect[i] = vect[i] + scalar;
            }
            return vect;
        }
        public static Vector operator -(Vector vect, int scalar)
        {
            for (int i = 0; i < vect.coords.Length; i++)
            {
                vect[i] = vect[i] - scalar;
            }
            return vect;
        }
        public static Vector operator *(Vector vect, int scalar)
        {
            for (int i = 0; i < vect.coords.Length; i++)
            {
                vect[i] = vect[i] * scalar;
            }
            return vect;
        }

        public static int operator *(Vector one, Vector two)
        {
            if (one.coords.Length != two.coords.Length)
            {
                throw new ArgumentException("Vector must have same lenght");
            }
            int dotProd = 0;
            for (int i = 0; i < one.coords.Length; i++)
            {
                dotProd += one[i] * two[i];
            }
            return dotProd;
        }
    }
}
