using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace D03
{
    internal class Point3D : Point2D, ICloneable
    {
        #region CTOR | Prop of 3D
        public int Z { get; set; }

        public Point3D() 
        {
            X = 0; 
            Y = 0;
            Z = 0;
        }

        public Point3D(Point3D p3)
        {
            X=p3.X;
            Y=p3.Y;
            Z=p3.Z;
        }

        public Point3D(int _X , int _Y , int _Z) :base(_X,_Y)
        {
            Z = _Z;
        }
        #endregion

        #region Operator Overloading
        public static Point3D operator +(Point3D l, Point3D r )
        {
           return new Point3D(l.X+r.X, l.Y + r.Y, l.Z+r.Z);
        }

        public static Point3D operator -(Point3D l, Point3D r)
        {
            return new Point3D(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        }

        public static Point3D operator ++(Point3D point)
        {
            return new Point3D(point.X + 1, point.Y + 1, point.Z);
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        }

        public static bool operator !=(Point3D left, Point3D right)
        {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z;
        }

        public static bool operator >(Point3D left, Point3D right)
        {
            return (left.X > right.X) && (left.Y > right.Y) && (left.Z > right.Z);
        }

        public static bool operator <(Point3D left, Point3D right)
        {
            return ((left.X < right.X) || (left.Y < right.Y)) && (left.Z < right.Z);
        }

        public static implicit operator string(Point3D p)
        {
            return $"Point Coordinates: ({p.X},{p.Y},{p.Z})";
        }

        #endregion

        #region Overrides and Interfaces
        public override bool Equals(object? obj)
        {
            // Point2D p = obj as Point2D /*?? new Point2D()*/; //is , as
            // if(p == null) return false;
            if (obj is Point3D)
            {
                Point3D p = (Point3D)obj; //Point2d p ; p = p3D
                Console.WriteLine("Inner Fun.");
                Console.WriteLine(GetType());
                Console.WriteLine(p.GetType());


                if (GetType() == p.GetType())
                    return X == p.X && Y == p.Y && Z == p.Z;
            }
            return false;
            // return base.Equals(obj);
        }

        public override string ToString()
        {
           // return $"({X},{Y},{Z} , {a} , {b} , {c})";
              return $"({X},{Y},{Z})";
        }

        public object  Clone()
        {
            Point3D p = new Point3D() {X = X, Y = Y , Z = Z } ;
            return p ;
        }
        #endregion

        #region Input Handling
        public static Point3D ReadPointFromUser(string pointName)
        {
            int x, y, z;
            Console.WriteLine($"Enter coordinates for {pointName}:");

            Console.Write("X: ");
            x = TryParseInput();

            Console.Write("Y: ");
            y = TryParseInput();

            Console.Write("Z: ");
            z = TryParseInput();

            return new Point3D(x, y, z);
        }

        private static int TryParseInput()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                    return result;

                Console.Write("Invalid input. Enter an integer: ");
            }
        }
        #endregion

        #region Sorting
        public static void SortPoints(Point3D[] points)
        {
            Array.Sort(points, (p1, p2) =>
            {
                if (p1.X != p2.X) 
                    return p1.X.CompareTo(p2.X);
                if (p1.Y != p2.Y)
                    return p1.Y.CompareTo(p2.Y);
                return p1.Z.CompareTo(p2.Z);
            });
        }
        #endregion
    }


}
