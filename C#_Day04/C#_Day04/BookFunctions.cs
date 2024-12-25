using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day04
{
    public class BookFunctions
    {
        public static string GetTitle(Book B) => B.Title;

       public static string GetAuthors(Book B)
        {
            //string s = " ";
            //for (int i = 0; i < B.Authors.Count; i++) 
            //{
            //    s += " " + B.Authors[i];
            //}
            //return s;
            return string.Join(", ", B.Authors);
        }

        public static string GetPrice(Book B)
        {
            string p = " ";
            p+= B.Price;

            return p;
        }
       
    }


}
