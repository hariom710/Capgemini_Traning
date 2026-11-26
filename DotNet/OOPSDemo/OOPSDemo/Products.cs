using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class Products : IComparable<Products>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(Products other)
        {
            if (other == null) return 1;
            return this.Price.CompareTo(other.Price);
        }
    }
}
