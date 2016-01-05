using System.Collections.Generic;

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
            foreach (KeyValuePair<int, int> item in cartItems)
            {
                if (item.Value == 1) { total += 100; }
            }

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