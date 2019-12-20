using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace test
{
    class Carts
    {
        private List<Cart> myCarts = new List<Cart>();

        public Carts AddItem(int price,int quantity = 1)
        {
            myCarts.Add(new Cart(myCarts.Count+1,price,quantity));
            return this;
        }
        public int totalOrder()
        {
            return myCarts.Count;
        }
        public long totalQuantity()
        {
            return myCarts.Sum(e => e.quantity);
        }
        public long totalPrice()
        {
            return myCarts.Sum(e => e.price*e.quantity);
        }
        public List<Cart> showAll()
        {
            foreach (var cart in myCarts)
            {
                Console.WriteLine($"Purchase ID : {cart.purchase_id}\tPrice : {cart.price}\tQuantity : {cart.quantity}");
            }
            return myCarts;
        }
        public void checkOut()
        {

        }

//cart.showAll() // Show all items in cart

//cart.checkout() // Store data in a file
    }
    class Cart
    {
        public int purchase_id { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

        public Cart(int purchase_id, int price, int quantity)
        {
            this.purchase_id = purchase_id;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
