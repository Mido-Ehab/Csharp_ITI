using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03
{
    internal static class Math
    {

        public static int Sum(int a , int b)
        {
            return a + b;
        }
        public static int Div(int a , int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new DivideByZeroException();
            }
        }
        public static int Sub (int a ,int  b)
        {
            return a - b;
        }
        public static int Mul(int a , int b)
        {
            return a * b;
        }
    }
}
