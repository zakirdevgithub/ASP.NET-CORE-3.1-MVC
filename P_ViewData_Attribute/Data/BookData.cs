using P_ViewData_Attribute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_ViewData_Attribute.Data
{
    public class BookData
    {
        private List<Book> BookList()
        {
            return new List<Book>()
            {
                new Book(){Id=1, Title="C Book", Author="Zakir Hossain", Description="This is C Programming Book. You can learn A lot of knowledge about C programming", Category="Programming",Pages=345},
                new Book(){Id=2, Title="C++ Book", Author="Keya Rahman", Description="This is C++ Programming Book. You can learn A lot of knowledge about C++ programming", Category="Programming",Pages=348},
                new Book(){Id=3, Title="C# Book", Author="Mitu Rahman", Description="This is C# Programming Book. You can learn A lot of knowledge about C# programming", Category="Programming",Pages=349},
                new Book(){Id=4, Title="Go Book", Author="Sanjida Rahman", Description="This is Go Programming Book. You can learn A lot of knowledge about Go programming", Category="Programming",Pages=145},
                new Book(){Id=5, Title="Dart Book", Author="Zahid Hasan", Description="This is Dart Programming Book. You can learn A lot of knowledge about Dart programming", Category="Programming",Pages=245},
                new Book(){Id=6, Title="JavaScript Book", Author="Jahangir Alam", Description="This is JavaScript Programming Book. You can learn A lot of knowledge about JavaScript programming", Category="Programming",Pages=545},
                new Book(){Id=7, Title="Python Book", Author="Ariful Islam", Description="This is Python Programming Book. You can learn A lot of knowledge about Python programming", Category="Programming",Pages=385},
                new Book(){Id=8, Title="Java Book", Author="Monirul Islam", Description="This is Java Programming Book. You can learn A lot of knowledge about Java programming", Category="Programming",Pages=945},
                new Book(){Id=9, Title="PHP Book", Author="Mamun Hasan", Description="This is PHP Programming Book. You can learn A lot of knowledge about PHP programming", Category="Programming",Pages=440},
            };

        }

        public List<Book> AllBooks()
        {
            return BookList();
        }
        public Book BookById(int id)
        {
            return BookList().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<Book> BookBySearch(string title, string author)
        {
            return BookList().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }
    }
}
