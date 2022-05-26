using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[2];
            Book b = new Book();
            b.author = "Steven King";
            b.title = "IT";
            b.pagesCount = 900;
            b.price = 20m;
            books[0] = b;

            Book b2 = new Book("Steven King", "Green mile", 554, 15.50m);
            books[1] = b2;

            Console.WriteLine("Books:");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"- {books[i].author}, {books[i].title}, {books[i].price}");
            }

            Console.WriteLine($"Total price of books {GetTotalPrice(books)}");
            Console.ReadLine();
        }

        public static decimal GetTotalPrice(Book[] books)
        {
            decimal totalAmount = 0;
            for (int i = 0; i < books.Length; i++)
                totalAmount += books[i].price;
            return totalAmount;
        }
    }
}
