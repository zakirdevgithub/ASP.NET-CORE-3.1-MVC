using O_ViewBag_ViewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O_ViewBag_ViewData.Data
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
        public List<Book> BookBySearch(string title, string author)
        {
            return BookList().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }


        private List<Book> BookList()
        {
            return new List<Book>()
            {
                new Book(){Id=0, Title="C++ in Action", Author="Zakir Hossain",Description="This is C++ programming book.", Category="Programming Language",Pages=235},
                new Book(){Id=1, Title="C in Action", Author="Keya Rahman",Description="This is C programming book.", Category="Programming Language",Pages=435},
                new Book(){Id=2, Title="C# in Action", Author="Mitu Rahman",Description="This is C# programming book.", Category="Programming Language",Pages=635},
                new Book(){Id=3, Title="Java in Action", Author="Sanjida Rahman",Description="This is Java programming book.", Category="Programming Language",Pages=735},
                new Book(){Id=4, Title="PHP in Action", Author="Zahid Hasan",Description="This is PHP programming book.", Category="Programming Language",Pages=335},
                new Book(){Id=5, Title="JavaScript in Action", Author="Monirul Islam",Description="This is JavaScript programming book.", Category="Programming Language",Pages=535},
                new Book(){Id=6, Title="Asp.net core 3.1", Author="Jahangir Alam",Description="This is Asp.net core 3.1 book for beginer", Category="Framework",Pages=935},
                new Book(){Id=7, Title="Angular in Action", Author="Rozina Akter",Description="This is Angular framework book.", Category="Framework",Pages=225},
                new Book(){Id=8, Title="Python in Action", Author="Noor Afsheen",Description="This is Python programming book.", Category="Programming Language",Pages=605},
            };
        }

    }

}

