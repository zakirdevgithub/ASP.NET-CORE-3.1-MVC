using K_Model_To_View_Data_Send.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace K_Model_To_View_Data_Send.Data
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
                new Book(){Id=0, Title="C# Book", Author="Zakir Hossain", Description="This is C# Book and You can learn easily C# programming language." },
                new Book(){Id=1, Title="C++ Book", Author="Keya Rahman", Description="This is C++ Book and You can learn easily C++ programming language." },
                new Book(){Id=2, Title="Python Book", Author="Zubayer Al Mamun", Description="This is Python Book and You can learn easily Python programming language." },
                new Book(){Id=3, Title="JavaScript Book", Author="Zahid Hasan", Description="This is JavaScript Book and You can learn easily JavaScript programming language." },
                new Book(){Id=4, Title="Java Book", Author="Zakir Hossain", Description="This is Java Book and You can learn easily Java programming language." },
                new Book(){Id=5, Title="PHP", Author="Rakib Rahman", Description="This is PHP Book and You can learn easily PHP programming language." },
                new Book(){Id=6, Title="Designing", Author="Keya Rahman", Description="This is Designing Book and You can learn easily Designing programming language." },
            };
        }
    }
}
