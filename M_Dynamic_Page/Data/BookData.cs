using M_Dynamic_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M_Dynamic_Page.Data
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
                new Book(){Id=0, Title="C Book", Author="Zakir Hossain", Description="This is C Programming Book for Beginer", Category="Programming", TotalPage="334" },
                new Book(){Id=1, Title="C++ Book", Author="Zahid Hossain", Description="This is C++ Programming Book for Beginer", Category="Programming", TotalPage="594" },
                new Book(){Id=2, Title="C# Book", Author="Zakir Hossain", Description="This is C# Programming Book for Beginer", Category="Programming", TotalPage="456" },
                new Book(){Id=3, Title="JavaScript Book", Author="Zakir Hossain", Description="This is JavaScript Programming Book for Beginer", Category="Programming", TotalPage="564" },
                new Book(){Id=4, Title="ASP.NET CORE Book", Author="Keya Rahman", Description="This is Asp.net core Book for Beginer", Category="Development", TotalPage="876" },
                new Book(){Id=5, Title="Java Book", Author="Setu Rahman", Description="This is Java Programming Book for Beginer", Category="Programming", TotalPage="394" },
                new Book(){Id=6, Title="Science Book", Author="Sanjida Rahman", Description="This is Science Programming Book for Beginer", Category="Programming", TotalPage="894" },
                new Book(){Id=7, Title="English Book", Author="Sanjida Rahman", Description="This is English Programming Book for Beginer", Category="Programming", TotalPage="994" },
                new Book(){Id=8, Title="Math Book", Author="Sanjida Rahman", Description="This is Math Programming Book for Beginer", Category="Programming", TotalPage="794" },

            };
        }
    }
}
