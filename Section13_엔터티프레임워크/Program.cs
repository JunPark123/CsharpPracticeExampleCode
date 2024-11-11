using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Section13_엔터티프레임워크.Models;

namespace Section13_엔터티프레임워크
{
    public class Program
    {
        static void insertBooks()
        {
            using (var db = new BooksDbContext())
            {
                var book1 = new Book
                {
                    Title = "별의 계승자",
                    PublishedYear = 1977,
                    Author = new Author
                    {
                        Birthday = new DateTime(1941, 6, 27),
                        Gender = "M",
                        Name = "박준",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book
                {
                    Title = "타임머신",
                    PublishedYear = 1933,
                    Author = new Author
                    {
                        Birthday = new DateTime(1933, 6, 27),
                        Gender = "F",
                        Name = "박다현",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }

        static IEnumerable<Book> GetBooks()
        {
            using (var db = new BooksDbContext())
            {
                return db.Books.Where(book => book.Author.Name.StartsWith("박준")).ToList();
            }
        }

        static void DisplayAllBooks()
        {
            var books = GetBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} {book.PublishedYear}");

            }
            Console.ReadLine();
        }

        static void AddAuthors()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = new Author
                {
                    Birthday = new DateTime(1923, 6, 27),
                    Gender = "F",
                    Name = "콩콩",
                };
                db.Author.Add(author1);

                var author2 = new Author
                {
                    Birthday = new DateTime(1953, 6, 27),
                    Gender = "F",
                    Name = "송송",
                };
                db.Author.Add(author2);
                db.SaveChanges();
            }

        }

        static void AddBooks()
        {
            using (var db = new BooksDbContext())
            {
                var ahthor1 = db.Author.Single(x => x.Name == "콩콩");
                var book1 = new Book
                {
                    Title = "별의 계승자",
                    PublishedYear = 1977,
                    Author = ahthor1,
                };
                db.Books.Add(book1);
                var ahthor2 = db.Author.Single(x => x.Name == "송송");
                var book2 = new Book
                {
                    Title = "타임머신",
                    PublishedYear = 1933,
                    Author = ahthor2,
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }
        static void Main(string[] args)
        {
            //insertBooks();
           // DisplayAllBooks();
           // AddAuthors();
            AddBooks();
        }
    }
}
