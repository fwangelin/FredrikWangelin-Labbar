using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10_Delegater
{
    public delegate bool BookFilter(Book book);

    public class Runtime
    {
        public void Start()
        {
            BookManager manager = new BookManager();

            Console.WriteLine("Novels:");
            manager.PrintWhere(IsNovel);

            Console.WriteLine("\nShort Stories:");
            manager.PrintWhere(IsShortStory);

            Console.WriteLine("\nMysteries:");
            manager.PrintWhere(IsGenreMystery);

            Console.WriteLine("\nFantasy:");
            manager.PrintWhere(IsGenreFantasy);

            Console.WriteLine("\nRomance:");
            manager.PrintWhere(IsGenreRomance);

            Console.WriteLine("\nCheapest books in stock:");
            manager.PrintWhere(IsCheap);

            Console.WriteLine("\nPricy books:");
            manager.PrintWhere(IsExpensive);
        }

        #region Filters
        public static bool IsNovel(Book book)
        {
            return book.Pages >= 101;
        }

        public static bool IsShortStory(Book book)
        {
            return book.Pages < 100;
        }

        public static bool IsGenreMystery(Book book)
        {
            return book.Genre == "Mystery";
        }

        public static bool IsGenreFantasy(Book book)
        {
            return book.Genre == "Fantasy";
        }

        public static bool IsGenreRomance(Book book)
        {
            return book.Genre == "Romance";
        }

        public static bool IsCheap(Book book)
        {
            return book.Price <= 150.90;
        }

        public static bool IsExpensive(Book book)
        {
            return book.Price >= 151;
        }
        #endregion
    }
}
