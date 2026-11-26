import { Component, computed, signal } from '@angular/core';

@Component({
  selector: 'app-appcart',
  standalone: false,
  templateUrl: './appcart.html',
  styleUrl: './appcart.css',
})
export class Appcart {
  price=signal(100);
  qty=signal(5);
  total=computed(() => this.price() * this.qty());

  increaseQty() {
    this.qty.update((value) => value + 1);
  }

  decreaseQty() {
    this.qty.update((value) => value - 1);
  }

  increasePrice() {
    this.price.update((value) => value + 10);
  }

  decreasePrice() {
    this.price.update((value) => value - 10);
  }
  
}
