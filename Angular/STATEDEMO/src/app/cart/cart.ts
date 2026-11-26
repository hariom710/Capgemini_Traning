import { Component } from '@angular/core';
import { Cartservice } from '../service/cartservice';

@Component({
  selector: 'app-cart',
  standalone: false,
  templateUrl: './cart.html',
  styleUrl: './cart.css',
})
export class Cart {
  cartItems: any[] = [];

  constructor(private cartService: Cartservice) {
    this.cartItems = this.cartService.getCartItems();
  }

  ngOnInit() {
    this.cartItems = this.cartService.getCartItems();
  }

  clearCart() {
    this.cartService.clearCart();
    this.cartItems = [];
  }

  getTotal(): number {
    return this.cartItems.reduce((sum, item) => sum + item.price, 0);
  }
}
