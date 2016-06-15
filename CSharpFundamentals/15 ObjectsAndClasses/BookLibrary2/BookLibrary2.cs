using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public static Library AddBooks()
        {
            int n = int.Parse(Console.ReadLine());
            var books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                books.Add(Book.ReadBooks());
            }
            var library = new Library { Books = books };
            return library;
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public static Book ReadBooks()
        {
            var input = Console.ReadLine().Split(' ');
            var book = new Book
            {
                Title = input[0],
                Author = input[1],
                Publisher = input[2],
                ReleaseDate = DateTime.ParseExact(input[3].ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = input[4],
                Price = decimal.Parse(input[5])
            };
            return book;
        }
    }
    class BookLibrary
    {
        static void Main(string[] args)
        {            
            var library = Library.AddBooks();

            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var dict = new Dictionary<string, DateTime>();
       
            foreach (var book in library.Books)
            {
                if ( book.ReleaseDate > date)
                dict.Add(book.Title, book.ReleaseDate);
            }
           
            var result = dict.OrderBy(x => x.Value).ThenBy(x => x.Key);
            foreach (var pair in result)
            {
                string formattedDate = pair.Value.ToString("dd.MM.yyyy");
                Console.WriteLine("{0} -> {1}", pair.Key, formattedDate);
            }
        }
    }
}
