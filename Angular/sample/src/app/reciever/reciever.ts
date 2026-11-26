import { Component } from '@angular/core';
import { Dataservice } from '../dataservice';


@Component({
  selector: 'app-reciever',
  standalone: false,
  templateUrl: './reciever.html',
  styleUrl: './reciever.css',
})
export class Reciever {
  receivedData = '';

  constructor(private dataService: Dataservice) {
    this.dataService.data$.subscribe((message: string) => {
      this.receivedData = message;
      
    });
  }
}
