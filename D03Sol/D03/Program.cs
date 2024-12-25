namespace D03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Static Class
            // Math m = new Math();
            // Math m;
            //Console.WriteLine(Math.Sub(10,20));
            //Console.WriteLine(Math.Sum(10,20));
            //Console.WriteLine(Math.Mul(10,20));
            //Console.WriteLine(Math.Div(10,20)); 
            #endregion

            #region Static Attr , Prop , Fun
            //Console.WriteLine(Player.Count);
            //Player p = new Player();
            //Console.WriteLine(Player.Count);
            //Player p1 = new Player("Ahmed");
            //Console.WriteLine(Player.Count);

            //Player p2 = new Player(10,20,"Ahmed"); 
            #endregion
            // Console.WriteLine(p2.Count); //Error

            #region Inhertance | Equal | is | as 
            // Point2D p = new Point2D( 5 , 10);
            // Point2D p1 = new Point2D(5 , 10);
            // //p1.X = 10;
            // //p1.Y = 20;
            // //p1.b = 10;


            // /*    
            //     Console.WriteLine(p);
            //     Console.WriteLine(p1);
            //     Point3D p3D = new Point3D(10, 10, 10);
            //     Console.WriteLine(p3D);
            // */
            // p = p1; //
            //// Console.WriteLine(p.GetHashCode());
            //// Console.WriteLine(p1.GetHashCode());
            // Point2D p2 = new Point2D(p);
            // Console.WriteLine(p2.GetHashCode());
            // Console.WriteLine(p.GetHashCode());
            // Point2D p3 =(Point2D) p2.Clone();
            // Console.WriteLine(p2.GetHashCode());
            // Console.WriteLine(p3.GetHashCode());
            // //string str = "Hi Hi";
            // Point3D p3D = new Point3D(5, 10, 10);
            // Console.WriteLine(p.GetType());
            // Console.WriteLine(p3D.GetType());
            // if (p.Equals(p3D)) //check refrence
            // {
            //     Console.WriteLine("p == p2");
            // }
            // else
            // {
            //     Console.WriteLine("p != p2");
            // } 
            #endregion

            #region Function OverLoading
            //double x = 10;
            //double y = 20;

            //Console.WriteLine(Sum(x , y));

            //string s1 = "Hi";
            //string s2 = " Welcome";

            //Console.WriteLine(Sum(s1 , s2)); 
            #endregion

            //int z = 0 , a = 10 , b = 20;
            //z = a + b;

            //Point2D p = new Point2D(5, 10);
            //Point2D p1 = new Point2D(15, 10);
            //Point2D p3;
            //p3 = p + p1;
            //Console.WriteLine(p3);
            //Point2D p4;
            //p4 = p3++;
            //Console.WriteLine($"p4 => {p4}  ---- p3 => {p3}");
            //p4 = ++p3;
            //Console.WriteLine($"p4 => {p4}  ---- p3 => {p3}");

            //int x = (int)p4;
            //string str = p4;
            //Console.WriteLine(str);

            #region testing Point3D class

            // ----------------------------------------------------I/P
            Console.Write("Enter the number of points: ");
            int numPoints = int.Parse(Console.ReadLine());

            var points = new Point3D[numPoints];
            for (int i = 0; i < numPoints; i++)
            {
                points[i] = Point3D.ReadPointFromUser($"Point {i + 1}");
            }

            //--------------------------------------------------- Math on the Points
            Console.WriteLine("\nMath operations on the Points");

            //---------------------------------------------------------Sum
            Point3D totalSum = new Point3D();
            foreach (var point in points)
            {
                totalSum = new Point3D(
                Math.Sum(totalSum.X, point.X),
                Math.Sum(totalSum.Y, point.Y),
                Math.Sum(totalSum.Z, point.Z));
            }
            Console.WriteLine($"Sum of all points: {totalSum}");



            //----------------------------------------------------------------Checking Equality
            Console.WriteLine("\nChecking for equal points:");
            bool hasEqualPoints = false;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    if (points[i] == points[j])
                    {
                        Console.WriteLine($"Point {i + 1} is equal to Point {j + 1}");
                        hasEqualPoints = true;
                    }
                }
            }
            if (!hasEqualPoints)
                Console.WriteLine("No equal points found.");

            //------------------------------------------------------------------Sorting
            Console.WriteLine("\nSorting the points...");
            Point3D.SortPoints(points);

            Console.WriteLine("Points after sorting:");
            foreach (var point in points)
                Console.WriteLine(point);
            #endregion

            #region Duration Class Testing

            // -------------------------------------------------------I/P  Constructors
            Console.WriteLine("pathing diff values to the Constructors:");
            Duration d1 = new Duration(1, 20, 15);
            Console.WriteLine(d1.ToString());

            Duration d2 = new Duration(3600);
            Console.WriteLine(d2.ToString());

            Duration d3 = new Duration(7800);
            Console.WriteLine(d3.ToString());

            Duration d4 = new Duration(666);
            Console.WriteLine(d4.ToString());

            //--------------------------------------------------->>>> Math Operations
            Console.WriteLine("\nMath Operations");
            Duration d5 = d1 + d3;
            Console.WriteLine($"d1 + d3 = {d5.ToString()}");

            //Duration d6 = d3 - d1;
            //Console.WriteLine($"d3 - d1 = {(string)d6}");

            Duration d7 = d1 + 7800;
            Console.WriteLine($"d1 + 7800 seconds = {d7.ToString()}");

            Duration d8 = new Duration(666) + d3;
            Console.WriteLine($"666 seconds + d3 = {d8.ToString()}");

            // -------------------------------------------------------->>>> Increment and Decrement
            Console.WriteLine("\nIncrement and Decrement:");
            d1++;
            Console.WriteLine($"d1 after ++: {d1.ToString()}");

            d3--;
            Console.WriteLine($"d3 after --: {d3.ToString()}");

            // ------------------------------------------------->>>>>>>>>>>>Testing Comparison Operators
            Console.WriteLine("\n Comparison Operators:");
            Console.WriteLine($"d1 > d2: {(d1 > d2)}");
            Console.WriteLine($"d1 < d2: {(d1 < d2)}");

            //------------------------------------------------------------->>>>> Time Format Display 
            Console.WriteLine("\n Conversion to DateTime:");
            DateTime dt = (DateTime)d1;
            Console.WriteLine($"d1 as DateTime: {dt.ToLongTimeString()}");

            //------------------------------------------------------------->>>> if(D1)
            Console.WriteLine("\nTesting Boolean Conversion:");
            if ((bool)d1)
            {
                Console.WriteLine("d1 is non-zero");
            }

            #endregion

        }

        public static int  Sum(int a , int b)
        {
            return a + b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static string Sum(string a, string b)
        {
            return a + b;
        }

        public static void Add(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Add( float b , int a  )
        {
            Console.WriteLine(a + b);
           // return a + b;
        }


    }
}
