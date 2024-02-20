using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettore
{
    internal class Vector
    {
        private readonly float x;
        private readonly float y;

        public float X { get { return x; } }
        public float Y { get { return y; } }

        public Vector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("{0};{1}", x, y);
        }

        public static Vector Parse(string s)
        {
            string[] strings= s.Split(';');
            return new Vector(float.Parse(strings[0]), float.Parse(strings[1]));
        }  

        public double Modulo()
        {
            return Math.Sqrt(X*X + Y * Y);
        }

        public static Vector operator +(Vector f, Vector p) 
        { 
            return new Vector (f.X + p.X, f.Y + p.Y);
        }

        public static Vector operator -(Vector f, Vector p)
        {
            return new Vector(f.X - p.X, f.Y - p.Y);
        }

        public static double operator *(Vector f, Vector p)
        {
            return f.X * p.X + f.Y * p.Y;
        }
        public static Vector operator *(Vector f, float scalar)
        {
            return new Vector(f.X * scalar, f.Y * scalar);
        }

        public static Vector operator *(float scalar, Vector f)
        {
            return new Vector(scalar * f.X , scalar * f.Y) ;
        }

        public static Vector operator /(Vector f, float scalar)
        {
            return new Vector(f.X / scalar, f.Y / scalar);
        }

        public static Vector operator -(Vector f)
        {
            return new Vector(-f.X, -f.Y);
        }

        public static Vector operator +(Vector f)
        {
            return new Vector(+f.X, +f.Y);
        }
    }
}
