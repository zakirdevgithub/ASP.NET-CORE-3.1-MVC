using Microsoft.EntityFrameworkCore;
using S_Connect_Database.DataContext;
using S_Connect_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S_Connect_Database.Data
{
    public class BookData
    {
        private readonly BookStoreContext _context = null;
        public BookData(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewBook(Book model)
        {
            var newBook = new BookModel()
            {
                Title = model.Title,
                Author = model.Author,
                Description = model.Description,
                Category=model.Category,
                TotalPage=model.TotalPage
            };
           await _context.Books.AddAsync(newBook);
           await _context.SaveChangesAsync();
            return newBook.Id;
        }
        private List<Book> BookList()
        {
           return new List<Book>()
            {
               new Book(){Id=1, Title="C# Book", Author="Zakir Hossain", Description="You can learn everything of C# in this book.", Category="Programming", TotalPage=345},
               new Book(){Id=2, Title="C++ Book", Author="Zakir Hossain", Description="You can learn everything of C++ in this book.", Category="Programming", TotalPage=445},
               new Book(){Id=3, Title="Java Book", Author="Zakir Hossain", Description="You can learn everything of Java in this book.", Category="Programming", TotalPage=545},
               new Book(){Id=4, Title="Python Book", Author="Zakir Hossain", Description="You can learn everything of Python in this book.", Category="Scripting", TotalPage=645},
               new Book(){Id=5, Title="JavaScript Book", Author="Zakir Hossain", Description="You can learn everything of JavaScript in this book.", Category="Scripting", TotalPage=745},
               new Book(){Id=6, Title="ASP.NET Core Book", Author="Zakir Hossain", Description="You can learn everything of ASP.NET Core in this book.", Category="Framework", TotalPage=845},
            };
        }

        public async  Task<List<Book>> AllBooks()
        {
            var books = new List<Book>();
           var allBooks= await _context.Books.ToListAsync();
            if (allBooks?.Any() == true)
            {
                foreach (var item in allBooks)
                {
                    books.Add(new Book()
                    {   Id = item.Id,
                        Title = item.Title,
                        Author = item.Author,
                        Description = item.Description,
                        Category = item.Category,
                        TotalPage = item.TotalPage
                    }) ;
                }
            }
            return books;
        }
        public async Task<Book> BookById(int id)
        {
           var item=await _context.Books.FindAsync(id);
           if(item != null)
            {
                var bookDetails = new Book()
                {   Id = item.Id,
                    Title = item.Title,
                    Author = item.Author,
                    Description = item.Description,
                    Category = item.Category,
                    TotalPage = item.TotalPage
                };
                return bookDetails;
            }
            return null;
           
        }
        public List<Book> BookBySearch(string title, string author)
        {
            return BookList().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }
    }
}
