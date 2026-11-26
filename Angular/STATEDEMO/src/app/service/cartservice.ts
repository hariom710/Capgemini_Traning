import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class Cartservice {
  cartItems: any[] = [];

  constructor() {}

  addToCart(item: any) {
    this.cartItems.push(item);
  }

  getCartItems() {
    return this.cartItems;
  }

  clearCart() {
    this.cartItems = [];
  }
}
