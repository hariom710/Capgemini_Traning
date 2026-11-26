import { Component } from '@angular/core';
import { signal,computed } from '@angular/core';

@Component({
  selector: 'app-signaldemo',
  standalone: false,
  templateUrl: './signaldemo.html',
  styleUrl: './signaldemo.css',
})
export class Signaldemo {
  counter = signal(0);
  derivedCounter = computed(() => this.counter() + 10);

  doubleCounter = computed(() => this.counter() * 2);

  increment() {
    this.counter.update((value) => value + 1);
  }

  decrement() {
    this.counter.update((value) => value - 1);
  }
}
