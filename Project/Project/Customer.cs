using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Customer : IBooks
    {
        Print p = new Print();

        public void Lists()
        {

            Console.WriteLine("Welcome to Online Book Store");

            Console.WriteLine("Book Category:  1- Computer    2- Maths    3- SS");
            int select = Convert.ToInt32(Console.ReadLine());

            if (select == 1)
            {
                p.PrintsCS();
            }
            if (select == 2)
            {
                p.PrintsMT();
            }

            if (select==3)
            {
                p.PrintsSS();
            }

            Console.WriteLine("List of Books");

            Console.WriteLine("Book Name: " + bookname);
            Console.WriteLine("Book ID: " + bookid);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Book Publisher: " + Publisher);


        }
    }
}
