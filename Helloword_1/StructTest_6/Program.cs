using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTest_6
{
    class Program
    {

        struct Book
        {
            public String title;
            public String author;
            public int book_id;
        }

        static void Main(string[] args)
        {
            Book book;
            book.title = "dasda";
            book.author = "kid";
            book.book_id = 13;
            Console.WriteLine(book.title);
            Console.WriteLine(book.author);
            Console.WriteLine(book.book_id);
            Console.ReadKey();
        }
    }
}
