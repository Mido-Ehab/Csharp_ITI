using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03
{
    internal class Duration :ICloneable
    {
        #region CTOR | Prop of 3D
        public int H { get; set; }
        public int M { get; set; }
        public int S { get; set; }

        public Duration()
        {
            H = 0;
            M = 0;
            S = 0;
        }

        public Duration(Duration d)
        {
            H = d.H;
            M = d.M;
            S = d.S;
        }

        public Duration(int h, int m, int s)
        {
            H = h;
            M = m;
            S = s;
            Normalize();
        }

        public Duration (int totalSec)
        {
            H = totalSec / 3600;
            M = (totalSec % 3600) / 60;
            S = totalSec % 60;
        }
        #endregion




        #region Operator OverLoading

        public static Duration operator +(Duration t1, Duration t2)
        {
            return new Duration(t1.H + t2.H, t1.M + t2.M, t1.S + t2.S);
        }
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.getTotalSeconds() + seconds);
        }
        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds; 
        }
        public static Duration operator -(Duration t1, Duration t2)
        {
            return new Duration(t1.H - t2.H, t1.M - t2.M, t1.S - t2.S);
        }
        public static Duration operator -(Duration d, int seconds)
        {
            return new Duration(d.getTotalSeconds() - seconds);
        }
        public static Duration operator ++(Duration duration)
        {
            return new Duration(duration.H + 1, duration.M + 1, duration.S + 1);
        }
        public static Duration operator --(Duration duration)
        {
            return new Duration(duration.H - 1, duration.M - 1, duration.S - 1);
        }
        public static bool operator ==(Duration t1, Duration t2)
        {
            return t1.H == t2.H && t1.M == t2.M && t1.S == t2.S;
        }
        public static bool operator !=(Duration t1, Duration t2)
        {
            return t1.H != t2.H || t1.M != t2.M || t1.S != t2.S;
        }
        public static bool operator >(Duration t1, Duration t2)
        {
            //return (t1.H > t2.H) && (t1.M > t2.M) && (t1.S > t2.S);
            return t1.getTotalSeconds() > t2.getTotalSeconds();
        }
        public static bool operator <(Duration t1, Duration t2)
        {
            //return (t1.H < t2.H) && (t1.M < t2.M) && (t1.S < t2.S);
            return t1.getTotalSeconds() < t2.getTotalSeconds();
        }
        public static implicit operator string(Duration d)
        {
            return $"Duration ({d.H},{d.M},{d.S})";
        }


        public static implicit operator bool(Duration d)
        {
            return d.getTotalSeconds() > 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.H, d.M, d.S);
        }
        #endregion


        #region Overrides and Interfaces and some methods


        private void Normalize()
        {
            if (S >= 60)
            {
                M += S / 60;
                S %= 60;
            }

            if (M >= 60)
            {
                H += M / 60;
                M %= 60;
            }

            //if (S < 0 || M < 0 || H < 0)
            //{
            //    throw new ArgumentException("Negative duration values are not allowed.");
            //}
        }


        public override bool Equals(object? obj)
        {
            if (obj is Duration)
            {
                Duration d = (Duration)obj;
                Console.WriteLine(GetType());
                Console.WriteLine(d.GetType());

                if (GetType() == d.GetType())
                {
                    return H == d.H && M == d.M && S == d.S;
                }

            }
            return false;
        }
        public override string ToString()
        {
            return $"(Hours: {H},Minutes: {M},Seconds: {S})";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(H, M, S);
        }


        public object Clone()
        {
            Duration d = new Duration() { H = H, M = M, S = S };
            return d;
        }
        #endregion

        #region Input Handling
        public static Duration TakeTimeFromUser(String Time)
        {
            int h, m, s;

            Console.WriteLine($"Enter coordinates for {Time}:");

            Console.Write("H: ");
            h = TryParseInput();

            Console.Write("M: ");
            m = TryParseInput();

            Console.Write("S: ");
            s = TryParseInput();

            return new Duration(h, m, s);
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
        public static void SortTime(Duration[] d)
        {
            Array.Sort(d, (d1, d2) =>
            {
                int result = d1.H.CompareTo(d2.H);
                if (result == 0)
                    result = d1.M.CompareTo(d2.M);
                if (result == 0)
                    result = d1.S.CompareTo(d2.S);
                return result;
            });

        }
        #endregion

        public int getTotalSeconds()
        {
            return H * 3600 + M * 60 + S;
        }

    }
}
