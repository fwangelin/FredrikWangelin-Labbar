using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10_Delegater
{
    class BookManager
    {
        public List<Book> BookList{ get; set; }

        public BookManager()
        {
            BookList = new List<Book>
            {
                new Book {Title = "What is that?",    Genre = "Mystery", Pages = 346, Price = 299.90 },
                new Book {Title = "The scary book",   Genre = "Mystery", Pages = 200, Price = 159.30 },
                new Book {Title = "The funny Book",   Genre = "Fantasy", Pages = 36,  Price = 99.90  },
                new Book {Title = "The bird book",    Genre = "Fantasy", Pages = 146, Price = 399.90 },
                new Book {Title = "Arnold kills",     Genre = "Romance", Pages = 247, Price = 69.90  },
                new Book {Title = "Dying at work?",   Genre = "Romance", Pages = 316, Price = 99.90  },
                new Book {Title = "My way",           Genre = "Mystery", Pages = 349, Price = 199.90 },
                new Book {Title = "Thats a knife",    Genre = "Romance", Pages = 746, Price = 999.90 },
                new Book {Title = "Talladega nights", Genre = "Fantasy", Pages = 396, Price = 499.90 },
                new Book {Title = "Stuff",            Genre = "Romance", Pages = 66,  Price = 399.90 },
                new Book {Title = "Falling from sky", Genre = "Mystery", Pages = 35,  Price = 199.90 },
                new Book {Title = "I found a clue",   Genre = "Fantasy", Pages = 98,  Price = 299.90 },
                new Book {Title = "He has a name",    Genre = "Mystery", Pages = 311, Price = 319.90 },
                new Book {Title = "A house",          Genre = "Romance", Pages = 646, Price = 129.90 },
                new Book {Title = "Why is that red?", Genre = "Mystery", Pages = 546, Price = 39.90  },
                new Book {Title = "Doing things",     Genre = "Romance", Pages = 396, Price = 49.90  }

            };
        }

        public void PrintWhere(BookFilter filter)
        {
            foreach (var book in BookList)
            {
                if (filter(book))
                    Console.WriteLine("Title: {0}, Price: {1}:-, Amount of pages: {2}", book.Title, book.Price, book.Pages);
            }
        }
    }
}
