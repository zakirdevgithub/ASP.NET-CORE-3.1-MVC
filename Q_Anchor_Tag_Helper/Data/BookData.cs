using Q_Anchor_Tag_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Q_Anchor_Tag_Helper.Data
{
    public class BookData
    { 
        private List<Book> BookList()
        {
            return new List<Book>()
            {
                new Book(){Id=1, Title="C++ Book", Author="Zakir Hossain", Description="This is C++ Book for beginer",Category="Programming", Pages=345},
                new Book(){Id=2, Title="C# Book", Author="Keya Rahman", Description="This is C# Book for beginer",Category="Programming", Pages=415},
                new Book(){Id=3, Title="JavaScript Book", Author="Mitu Rahman", Description="This is JavaScript Book for beginer",Category="Programming", Pages=215},
                new Book(){Id=4, Title="Python Book", Author="Sanjida Rahman", Description="This is Python Book for beginer",Category="Programming", Pages=565},
                new Book(){Id=5, Title="Asp.net core Book", Author="Mahmuda Rahman", Description="This is Asp.net core Book for beginer",Category="Framework", Pages=453},
                new Book(){Id=6, Title="Angular Book", Author="Zahid Hasan", Description="This is Angular Book for beginer",Category="Framework", Pages=673}
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
