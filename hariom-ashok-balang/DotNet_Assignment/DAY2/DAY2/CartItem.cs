using System;
namespace DAY2
{
    internal class CartItem
    {
        private string _itemName;
        private decimal _price;
        private int _quantity;
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value >= 0)
                    _quantity = value;
                else
                    Console.WriteLine("Quantity must be zero or greater.");
            }
        }
    }
}