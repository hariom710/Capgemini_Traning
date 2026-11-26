import { Component } from '@angular/core';
import {DataService} from '../data';

@Component({
  selector: 'app-sender',
  standalone: false,
  templateUrl: './sender.html',
  styleUrl: './sender.css',
})
export class SenderComponent{
constructor(private data:DataService){}
updateMessage(value:string){
this.data.changeMessage(value);
}
}
