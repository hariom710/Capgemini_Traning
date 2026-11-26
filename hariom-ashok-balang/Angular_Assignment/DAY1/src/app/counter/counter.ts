import { Component } from '@angular/core';

@Component({
  selector: 'app-counter',
  standalone: false,
  templateUrl: './counter.html',
  styleUrl: './counter.css',
})
export class CounterComponent {

 count = 0;

 increase(){
  this.count++;
 }

 decrease(){
  this.count--;
 }

}
