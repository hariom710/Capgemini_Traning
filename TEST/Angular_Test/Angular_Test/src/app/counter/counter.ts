import { Component } from '@angular/core';

@Component({
  selector: 'app-counter',
  standalone: false,
  templateUrl: './counter.html',
  styleUrl: './counter.css',
})
export class Counter {
  count = 0;
  increment(): void {
    this.count++;
  }
  decrement(): void {
    if (this.count > 0) {
      this.count--;
    }
  }
}

