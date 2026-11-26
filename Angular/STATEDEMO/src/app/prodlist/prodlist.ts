import { Component } from '@angular/core';
import { Cartservice } from '../service/cartservice';
import { Router } from '@angular/router';

@Component({
  selector: 'app-prodlist',
  standalone: false,
  templateUrl: './prodlist.html',
  styleUrl: './prodlist.css',
})
export class Prodlist {
  cartlist: any[] = [];

  products = [
    { id: 1, name: 'Product 1', price: 10 },
    { id: 2, name: 'Product 2', price: 20 },
    { id: 3, name: 'Product 3', price: 30 },
  ];

  constructor(private cartService: Cartservice, private router: Router) {}

  addToCart(product: any) {
    this.cartService.addToCart(product);
    alert(`${product.name} added to cart!`);
  }

  displayCart() {
    this.router.navigate(['/cart']);
  }
}
