import { Component } from '@angular/core';

@Component({
  selector: 'app-click-counter',
  standalone: false,
  templateUrl: './click-counter.html',
  styleUrl: './click-counter.css',
})
export class ClickCounter {
  count = 0;

  increase(){
    this.count++;
  }
}
