
namespace C__Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of books
            List<Book> books = new List<Book>
            {
                new Book("12345", "C# in Depth", new List<string> { "Jon Skeet" }, new DateTime(2019, 3, 23), 55.2m),
                new Book("67890", "Clean Code", new List<string> { "Robert C. Martin" }, new DateTime(2008, 8, 11), 50),
                new Book("11223", "The Pragmatic Programmer", new List<string> { "Andrew Hunt", "David Thomas" }, new DateTime(1999, 10, 30),70)
            };

            
            Console.WriteLine("Book Titles:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

           
            Console.WriteLine("\nBook Authors:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

           
            Console.WriteLine("\nBook Prices:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);

         
            Console.WriteLine("\nBook ISBNs:");
            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });

   
            Console.WriteLine("\nBook Publication Dates:");
            LibraryEngine.ProcessBooks(books, b => b.PublicationDate.ToShortDateString());

            Console.WriteLine("\nBook Details:");
            LibraryEngine.ProcessBooks(books, b => b.ToString());
        }
    }
}
