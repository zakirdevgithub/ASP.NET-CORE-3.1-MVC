using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Data;
using W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Models;

namespace W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Station
{
    public class BookStation
    {
        private readonly DataContext _context = null;

        public BookStation(DataContext context)
        {
            _context = context;
        }

        public int AddNewBook(BookModel model)
        {
            var books = new Book()
            {
                Id=model.Id,
                Title=model.Title,
                Author=model.Author,
                Description=model.Description,
                Category=model.Category,
                TotalPage=model.TotalPage,
                LanguageId=model.LanguageId    
            };

            _context.Books.Add(books);
            _context.SaveChanges();

            return books.Id;

        }

        public List<BookModel> GetAllBooks()
        {
            var getBook = new List<BookModel>();
            var books=_context.Books.ToList();

            if (books?.Any() == true)
            {
                foreach (var book in books)
                {
                    getBook.Add(new BookModel()
                    {
                        Id=book.Id,
                        Title=book.Title,
                        Author=book.Author,
                        Description=book.Description,
                        Category=book.Category,
                        TotalPage=book.TotalPage,
                        LanguageId=book.LanguageId
                    });
                }
            }

            return getBook;
        }

        public BookModel GetBookById(int id)
        {
            return _context.Books.Where(x => x.Id == id).Select(x => new BookModel()
            {
                Id=x.Id,
                Title=x.Title,
                Author=x.Author,
                Description=x.Description,
                Category=x.Category,
                TotalPage=x.TotalPage,
                LanguageId=x.LanguageId,
                Language=x.Language.Name
            }).FirstOrDefault();
        }
    }
}
