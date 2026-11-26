import {Component} from '@angular/core';
import {DataService} from '../data';

@Component({
  selector: 'app-sender',
  standalone: false,
  templateUrl: './sender.html',
  styleUrl: './sender.css',
})
export class SenderComponent{
constructor(private data:DataService){}
send(msg:string){
this.data.updateMessage(msg);
}
}
