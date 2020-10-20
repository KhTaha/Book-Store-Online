using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Print : IBooks
    {
        
        public Print() { }
        public void PrintsSS()
        {
            List<ISocialSc> books = new List<ISocialSc>();
           AddBooks(bookname, bookid, Author, Publisher);
            ISocialSc ss = new ISocialSc();
            books = ss.AddBook();
            for (int b = 0; b < books.Count; b++)
            {
                Console.WriteLine("Book Name: " + books[b].bookname);
                Console.WriteLine("Book ID: " +books[b].bookid);
                Console.WriteLine("Author: " + books[b].Author);
                Console.WriteLine("Book Publisher: " + books[b].Publisher);
                Console.WriteLine("");


            }


        }

        public void PrintsCS()
        {
            List<Computer> books = new List<Computer>();
            AddBooks(bookname, bookid, Author, Publisher);
          Computer ss = new Computer();
            books = ss.AddBook();
            for (int b = 0; b < books.Count; b++)
            {
                Console.WriteLine("Book Name: " + books[b].bookname);
                Console.WriteLine("Book ID: " + books[b].bookid);
                Console.WriteLine("Author: " + books[b].Author);
                Console.WriteLine("Book Publisher: " + books[b].Publisher);
                Console.WriteLine("");


            }


        }


        public void PrintsMT()
        {
            List<ISocialSc> books = new List<ISocialSc>();
            AddBooks(bookname, bookid, Author, Publisher);
            ISocialSc ss = new ISocialSc();
            books = ss.AddBook();
            for (int b = 0; b < books.Count; b++)
            {
                Console.WriteLine("Book Name: " + books[b].bookname);
                Console.WriteLine("Book ID: " + books[b].bookid);
                Console.WriteLine("Author: " + books[b].Author);
                Console.WriteLine("Book Publisher: " + books[b].Publisher);
                Console.WriteLine("");


            }


        }

    }
}
