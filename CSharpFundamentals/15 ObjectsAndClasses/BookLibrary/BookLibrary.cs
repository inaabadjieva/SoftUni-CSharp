using System;
using System.Collections.Generic;
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
        public string ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public static Book ReadBooks()
        {
            var input = Console.ReadLine().Split(' ');
            var book = new Book { Title = input[0], Author = input[1], Publisher = input[2], ReleaseDate = input[3], ISBN = input[4], Price = decimal.Parse(input[5]) };
            return book;
        }
    }
    class BookLibrary
    {
        static void Main(string[] args)
        {
            var library = Library.AddBooks();
            var dict = new Dictionary<string, decimal>();
            
            var authors = library.Books.Select(x => x.Author).Distinct().ToList();
     
            foreach (var author in authors)
            {
                dict.Add(author, library.Books.Where(x => x.Author == author).Select(x => x.Price).Sum());               
            }
            var result = dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var pair in result)
            {
                Console.WriteLine("{0} -> {1:f2}", pair.Key, pair.Value);
            }
        }
    }
}
