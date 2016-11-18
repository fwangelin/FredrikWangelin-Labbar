using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb14_KlasserObjektArvPolymorfism.Book;

namespace Labb14_KlasserObjektArvPolymorfism
{
    class Runtime
    {
        public void Start()
        {
            Author author1 = new Author { Name = "Nisse", Age = 12 };
            Author author2 = new Author { Name = "Leif", Age = 28 };
            Author author3 = new Author { Name = "Bosse", Age = 99 };
            

            Book book1 = new Book { author = author1, Title = "The Great One",      Genres = Genre.Biography, Pages = 251, ReleaseDate = DateTime.Today.AddHours(19).AddMinutes(10) };
            Book book2 = new Book { author = author2, Title = "Space: A biography", Genres = Genre.SciFi,     Pages = 202, ReleaseDate = DateTime.MaxValue };
            Book book3 = new Book { author = author3, Title = "Laughing",           Genres = Genre.Comedy,    Pages = 251, ReleaseDate = DateTime.UtcNow };

            Paper paper1 = new Paper { Title = "Tidsrapport:1", author = author2, ReleaseDate = DateTime.Today.AddHours(18.50) };
            Paper paper2 = new Paper { Title = "Årsredovisning", author = author1, ReleaseDate = DateTime.MinValue, };

            Magazine magazine1 = new Magazine { Title = "SVD", HeadLine = "Domedagen är här", author = author3, ReleaseDate = DateTime.Today.AddHours(07).AddMinutes(11)};
            Magazine magazine2 = new Magazine { Title = "DN", HeadLine = "Slutet är nära",    author = author1, ReleaseDate = DateTime.Today.AddHours(07).AddMinutes(26)};

            Console.WriteLine("Books:");
            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
            Console.WriteLine();
            Console.WriteLine("Papers:");
            Console.WriteLine(paper1);
            Console.WriteLine(paper2);
            Console.WriteLine();
            Console.WriteLine("Magazines:");
            Console.WriteLine(magazine1);
            Console.WriteLine(magazine2);
            Console.Read();
        }

    }
}
