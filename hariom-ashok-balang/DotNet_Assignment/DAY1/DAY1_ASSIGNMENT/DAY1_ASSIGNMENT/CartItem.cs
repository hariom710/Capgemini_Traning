using System;

namespace DAY1_ASSIGNMENT
{
    internal class CartItem
    {
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal CalculateTotalPrice()
        {
            return Price * Quantity;
        }
    }
}
