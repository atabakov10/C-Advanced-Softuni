using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBook
{
    public class Book
    {
        public string author;
        public string title;
        public int pagesCount;
        public decimal price;

        public Book()
        { 

        }

        public Book(string author, string title, int pages, decimal price)
        {
            this.author = author;
            this.title = title;
            this.pagesCount = pages;
            this.price = price;
        }

        public string GetBookInfo() 
        {
            return $"Author {author}, Title {title}, Price {price}";
        }
    }
}
