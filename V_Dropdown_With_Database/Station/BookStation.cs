using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V_Dropdown_With_Database.Data;
using V_Dropdown_With_Database.Models;

namespace V_Dropdown_With_Database.Station
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
            var books = new List<BookModel>();
            var allBooks = _context.Books.ToList();
            if(allBooks?. Any() == true)
            {
                foreach (var book in allBooks)
                {
                    books.Add(new BookModel()
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Author = book.Author,
                        Description = book.Description,
                        Category = book.Category,
                        TotalPage = book.TotalPage,
                        LanguageId = book.LanguageId,
                  
                        
                 
                    }); 

                }

                
            }
            return books;
        }

        public BookModel BookById(int id)
        {
            return _context.Books.Where(x => x.Id == id).Select(book => new BookModel()
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Description = book.Description,
                Category = book.Category,
                TotalPage = book.TotalPage,
                LanguageId = book.LanguageId,
       
                Language = book.Language.Name

             
            }).FirstOrDefault();

            
        }
    }
}
