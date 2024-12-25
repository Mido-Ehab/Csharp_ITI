using System;
using System.Collections.Generic;

namespace C__Day04
{
   
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (var book in bList)
            {
                Console.WriteLine(fPtr(book));
            }
        }
    }
}
