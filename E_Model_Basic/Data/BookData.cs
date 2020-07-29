using E_Model_Basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace E_Model_Basic.Data
{
    public class BookData
    {
        public List<Book> AllBooks()
        {
            return BookList();
        }
        public Book BookById(int id)
        {
            return BookList().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<Book> SearchBook(string title, string author)
        {
            return BookList().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }


        private List<Book> BookList()
        {
            return new List<Book>()
            {
                new Book(){Id=1,Title="Cplusplus", Author="Zakir"},
                new Book(){Id=2,Title="Csharp", Author="Zakir"},
                new Book(){Id=3,Title="Python", Author="Jewel"},
                new Book(){Id=4,Title="JavaScript", Author="Limon"},
                new Book(){Id=5,Title="Dart", Author="Pranto"}
            };
        }
    }
}
