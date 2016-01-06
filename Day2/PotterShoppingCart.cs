using System.Collections.Generic;
using System;

namespace PotterShoppingCart
{
    public class PotterShoppingCart
    {
        private Dictionary<int, int> cartItems;

        public PotterShoppingCart()
        {
            cartItems = new Dictionary<int, int>();
        }

        public int getTotalAmount()
        {
            int total = 0;
            double discount = 1.0;
            foreach (KeyValuePair<int, int> item in cartItems)
            {
                if (item.Value == 1) { total += 100; }
            }
            switch (cartItems.Count)
            {
                case 2:
                    discount = 0.95;
                    break;
                case 3:
                    discount = 0.9;
                    break;
                case 4:
                    discount = 0.8;
                    break;
                case 5:
                    discount = 0.75;
                    break;
                default:
                    break;
            }
            total = (int) ((double)total * discount);
            return total;
        }

        public void addToCart(int bookId)
        {
            if (cartItems.ContainsKey(bookId)) { 
                cartItems[bookId] += 1;
            }
            else
            {
                cartItems.Add(bookId, 1);
            }
        }
    }
}