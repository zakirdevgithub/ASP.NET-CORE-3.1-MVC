using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_Form_Validation.Data;
using T_Form_Validation.Models;

namespace T_Form_Validation
{
    public class BookRepository
    {
        private readonly DataContext _context = null;
        public BookRepository(DataContext context)
        {
            _context = context;
        }
         
        public async Task<int> AddNewBook(Book model)
        {
            var book = new CopyBook()
            {
                Id=model.Id,
                Title = model.Title,
                Author=model.Author,
                Description=model.Description,
                Category=model.Category,
                TotalPage=model.TotalPage
            };
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            return book.Id;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            var books = new List<Book>();
            var allBooks = await _context.Books.ToListAsync();
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
                        TotalPage=book.TotalPage
                    });

                }
                
            }
            return books;
        }

        public async Task<Book> GetBookById(int id)
        {
            
           var item= await _context.Books.Where(x=> x.Id==id).FirstOrDefaultAsync();
            if(item != null)
            {
                var books = new Book()
                {
                    Id=item.Id,
                    Title=item.Title,
                    Author=item.Author,
                    Description=item.Description,
                    Category=item.Category,
                    TotalPage=item.TotalPage
                };

                return books;
            }
            return null;
        }
    }
}
