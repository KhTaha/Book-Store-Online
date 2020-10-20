using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Order : IBooks
    {
        public int orderid { get; set; }
        public int custid { get; set; }
        public int bookid { get; set; }
        public int quantity { get; set; }

       

        public Order() { }

        public void PlaceOrder(int oi, int cutid, int bid, int q)
        {
            orderid = oi;
            custid = cutid;
           
            quantity = q;

            Console.WriteLine(" " + orderid + " " + custid + " " + bid +  " " + quantity);
        }




    }
}
