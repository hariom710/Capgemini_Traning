using System;
namespace DAY2
{
    internal class Product
    {
        private int _productId;
        private string _name;
        private decimal _price;
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                    _price = value;
                else
                    Console.WriteLine("Price cannot be negative.");
            }
        }
    }
}