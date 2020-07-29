using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using U_Dropdown_HardCoded.Data;
using U_Dropdown_HardCoded.Models;

namespace U_Dropdown_HardCoded.Station
{
    public class BookExpress
    {
        private readonly DataContext _context = null;
        public BookExpress(DataContext context)
        {
            _context = context;
        }

        public int PassingBookData(Book model)
        {
            var copyBook = new CopyBook()
            {
                Title = model.Title,
                Author = model.Author,
                Description = model.Description,
                Category = model.Category,
                TotalPage = model.TotalPage.HasValue ? model.TotalPage.Value : 0,
                Language=model.Language
            };
            _context.Books.Add(copyBook);
            _context.SaveChanges();
            return copyBook.Id;
        }

        public List<Book> GetAllBooks()
        {
            var books = new List<Book>();
            var allBooks = _context.Books.ToList();
            if (allBooks?.Any() == true)
            {
                foreach(var book in allBooks)
                {
                    books.Add(new Book()
                    {
                        Id=book.Id,
                        Title=book.Title,
                        Author=book.Author,
                        Description=book.Description,
                        Category=book.Category,
                        TotalPage=book.TotalPage,
                        Language=book.Language
                    });
                }
            }
            return books;
        }

        public Book BookById(int id)
        {
           var bookDetails= _context.Books.Where(x => x.Id == id).FirstOrDefault();
            if(bookDetails != null)
            {
                var book = new Book()
                {
                    Id=bookDetails.Id,
                    Title=bookDetails.Title,
                    Author=bookDetails.Author,
                    Description=bookDetails.Description,
                    Category=bookDetails.Category,
                    TotalPage=bookDetails.TotalPage,
                    Language=bookDetails.Language
                };
                return book;
            }
            return null;
        }
    }
}
