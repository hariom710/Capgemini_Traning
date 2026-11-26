using System;

namespace E_Commerce_System
{
    internal interface ICart
    {
        void AddToCart(Product p);
        void RemoveFromCart(Product p);
        void Checkout();
    }
}