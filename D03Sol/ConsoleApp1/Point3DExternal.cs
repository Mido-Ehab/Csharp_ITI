using D03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point3DExternal : Point2D
    {
        public int Z { get; set; }
        public override string ToString()
        {
            return $"({X},{Y},{Z},{a},{b})"; //C private Protected Error
        }
    }
}
