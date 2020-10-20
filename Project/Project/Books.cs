using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
  public  abstract class IBooks
    {

        public string Category { get; set; }
        public string bookname { get; set; }

        public int bookid { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public void AddBooks(string bookname, int id, string author, string pub) { }
    }
    public class Computer : IBooks
    {

     
        public List<Computer> AddBook()
        {

            //this.bookname = bookname;
            //this.bookid = id;
            //this.Author = author;
            //this.Publisher = pub;
            List<Computer> comp = new List<Computer>() { new Computer() { bookname="ITC",bookid= 2, Author="Tahaa",Publisher= "KIA" },
                                                    new Computer() { bookname="TOA",bookid= 2, Author="Umair",Publisher= "KIA" },
                                                    new Computer() { bookname="CPP",bookid= 2, Author="Ibrahim",Publisher= "KIA" },
                                                    new Computer() { bookname="ISL",bookid= 2, Author="M Mazhar Sb",Publisher= "KIA" }};

            return comp;
        }




    }
      public  class IMaths : IBooks
        {

       

        public List<IMaths> AddBook()
            {
            //this.bookname = bookname;
            //this.bookid = id;
            //this.Author = author;
            //this.Publisher = pub;

            List<IMaths> maths
                = new List<IMaths>() { new IMaths() { bookname="ITC",bookid= 2, Author="Tahaa",Publisher= "KIA" },
                                                    new IMaths() { bookname="TOA",bookid= 2, Author="Ishaq",Publisher= "KIA" },
                                                    new IMaths() { bookname="CPP",bookid= 2, Author="Ismail",Publisher= "KIA" },
                                                    new IMaths() { bookname="ARABIC",bookid= 2, Author="M Mazhar Sb",Publisher= "KIA" }};

            return maths;
        }

            

        }

        class ISocialSc : IBooks
        {
       


        public List<ISocialSc> AddBook()
            {
            //this.bookname = bookname;
            //this.bookid = id;
            //this.Author = author;
            //this.Publisher = pub;

            List<ISocialSc> ss = new List<ISocialSc>() { new ISocialSc() { bookname="ITC",bookid= 2, Author="Tahaa",Publisher= "KIA" },
                                                    new ISocialSc() { bookname="TOA",bookid= 2, Author="Ishaq",Publisher= "KIA" },
                                                    new ISocialSc() { bookname="CPP",bookid= 2, Author="Ismail",Publisher= "KIA" },
                                                    new ISocialSc() { bookname="ARABIC",bookid= 2, Author="M Mazhar Sb",Publisher= "KIA" }};


            return ss;
            }
        }



    
    
}
