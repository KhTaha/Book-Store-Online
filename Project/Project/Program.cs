using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            main m = new main();
            m.Main();
            Console.WriteLine("...................Thanks for Visiting Us!! follow us on.................");

        }
        public class main
        {
            LogAdmin adm = new LogAdmin();
            UserLogin usr = new UserLogin();

            public void Main()
            {
                Console.WriteLine("Login as \r\n 1- Admin \r\n 2- User ");
                int login = Convert.ToInt32(Console.ReadLine());

                if (login == 1)

                {
                    adm.login();

                }


                if (login == 2)
                {
                    usr.Login();
                }

            }
        }
           
        


        public class Admin
        {
            public bool Check ()
            {
                bool check=false;
                Console.WriteLine("Enter Admin Name:  ");
                string admin = Console.ReadLine();
                Console.WriteLine("Enter Password:    ");
                string pass = Console.ReadLine();

                check=admin.Equals("Taha")&&pass.Equals("Taha123");


                return check;
            }
        }

        int abc =0;
        public class LogAdmin
        {

            Print p = new Print();


            List<IBooks> books = new List<IBooks>();

            string Y;

            public void login()
            {
                

                
                    Admin admin = new Admin();
                    if (admin.Check().Equals(true))
                    {
                        Console.WriteLine("Welcome to Online Book Store");
                        Console.WriteLine("");

                    Console.WriteLine("DO you want to add books? " + "/n" + " Y / N");
                    Y = Console.ReadLine();

                    while (Y == "Y")
                    {



                            Console.WriteLine("Book Category: \n Computer \n Maths \n SS");
                            p.Category = Console.ReadLine();

                            Console.WriteLine("Book Name: ");
                            p.bookname = Console.ReadLine();

                            Console.WriteLine("Book ID: ");
                            p.bookid = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Author: ");
                            p.Author = Console.ReadLine();

                            Console.WriteLine("Publisher:");
                            p.Publisher = Console.ReadLine();


                            books.Add(p);


                            Console.WriteLine("DO you want to add more books? " + "/n" + " Y / N");
                            Y = Console.ReadLine();

                        }

                    Console.Clear();

                    Console.WriteLine("\n\n ..............Books Detail.......... \n\n");

                        for (int b = 0; b < books.Count-1 ; b++)
                        {

                            Console.WriteLine("Category: " + books[b].Category);
                            Console.WriteLine("Book Name:  " + books[b].bookname);
                            Console.WriteLine("Book ID:  " + books[b].bookid);
                            Console.WriteLine("Author:  " + books[b].Author);
                            Console.WriteLine("Publisher:  " + books[b].Publisher);

                        }
                    }
                    else
                    {
                        main m = new main();
                        Console.WriteLine("\n Invalid Entry \n Do you want to Login again? Y / N ");
                        string log = Console.ReadLine();
                        if (log == "Y")
                        {
                        m.Main();
                        }
                    }

                
            }

        }


        public class UserLogin
        {

            Order o = new Order();
           private readonly Random _random = new Random();

            public void Login()
            {

                Customer cc = new Customer();
                cc.Lists();


            //  o.PlaceOrder(1, 1, 260, 3);
            Console.WriteLine("\n\n DO you want order books? Y / N");
                string choice = Console.ReadLine();

                while(choice == "Y")
                {


                    o.orderid = _random.Next(1000);
                    Console.WriteLine("\n\n Order ID: " + o.orderid);
                   

                    Console.WriteLine("Customer ID: ");
                    o.custid = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine("Order ID: ");
                    //o.price = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Book ID: ");
                    o.bookid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Quantity: ");
                    o.quantity = Convert.ToInt32(Console.ReadLine());

                    List<Order> order = new List<Order>();

                    order.Add(o);

                    Console.WriteLine("\n\n DO you want order more books? Y / N");
                   choice = Console.ReadLine();
                }


              
            }
        }


    }
}