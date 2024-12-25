using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03
{
    public class Point2D : ICloneable
    {
        // int x;
        protected int a;
        internal protected int b;
        private protected int c;

        #region CTOR | Prop
        public int A
        {
            get
            { return a; }
            set { a = value; }
        }
        public int X { get; set; } //private X , setX(value)=> X = value , getX()=> return X
        public int Y { get; set; }
        public Point2D(Point2D p)
        {
            X = p.X;
            Y = p.Y;

        }
        public Point2D()
        {
            X = 0;
            Y = 0;
        }
        public Point2D(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        #endregion




        public static Point2D operator +(Point2D l, Point2D r)
        {
            return new Point2D(l.X + r.X, l.Y + r.Y);
        }

        public static Point2D operator -(Point2D l, Point2D r)
        {
            return new Point2D(l.X - r.X, l.Y - r.Y);
        }

        public static Point2D operator ++(Point2D point)
        {
            return new Point2D(point.X + 1, point.Y + 1);
        }


        public static bool operator ==(Point2D left, Point2D right)
        {
            return left.X == right.X && left.Y == right.Y;
        }

        public static bool operator !=(Point2D left, Point2D right)
        {
            return left.X != right.X || left.Y != right.Y;
        }
        public static bool operator >(Point2D left, Point2D right)
        {
            return left.X > right.X && left.Y > right.Y;
        }

        public static bool operator <(Point2D left, Point2D right)
        {
            return left.X < right.X && left.Y < right.Y;
        }

        public static explicit operator int(Point2D p)
        {
            return p.X;
        }

        public static implicit operator string(Point2D p)
        {
            return $"({p.X},{p.Y})";
        }





















        public override bool Equals(object? obj)
        {
         // Point2D p = obj as Point2D /*?? new Point2D()*/; //is , as
         // if(p == null) return false;
           if(obj is Point2D)
             {
                 Point2D p = (Point2D)obj; //Point2d p ; p = p3D
                Console.WriteLine("Inner Fun.");
                Console.WriteLine(GetType());
                Console.WriteLine(p.GetType());


                if (GetType() == p.GetType())
                 return X == p.X && Y == p.Y ;
            }
           return false;
           // return base.Equals(obj);
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public object Clone()
        {
          //  throw new NotImplementedException();
          Point2D p = new Point2D() { X = X, Y = Y };
          return p;
        }
    }
}
