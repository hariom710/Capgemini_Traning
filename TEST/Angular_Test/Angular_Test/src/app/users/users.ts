import { Component } from '@angular/core';
import { OnInit } from '@angular/core';
import { Httpservice, Product } from '../httpservice';

@Component({
  selector: 'app-users',
  standalone: false,
  templateUrl: './users.html',
  styleUrl: './users.css',
})

export class Users implements OnInit {
  products: Product[] = [];
  errorMessage = '';

  constructor(private httpService: Httpservice) {}

  ngOnInit(): void {
    this.httpService.getProducts().subscribe({
      next: (data) => (this.products = data),
      error: () => (this.errorMessage = 'Failed to load products.'),
    });
  }
}
