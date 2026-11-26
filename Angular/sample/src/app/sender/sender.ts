import { Component } from '@angular/core';
import { Dataservice } from '../dataservice';


@Component({
  selector: 'app-sender',
  standalone: false,
  templateUrl: './sender.html',
  styleUrl: './sender.css',
})
export class Sender {
  sentData = '';

  constructor(private dataService: Dataservice) {}

  sendData() {
    this.sentData = 'Hello from Sender!';
    this.dataService.updateMessage(this.sentData);
  }
}
