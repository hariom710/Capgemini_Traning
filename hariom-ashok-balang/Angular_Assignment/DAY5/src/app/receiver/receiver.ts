import {Component,OnInit} from '@angular/core';
import {DataService} from '../data';

@Component({
  selector: 'app-receiver',
  standalone: false,
  templateUrl: './receiver.html',
  styleUrl: './receiver.css',
})
export class ReceiverComponent implements OnInit{
message='';
constructor(private data:DataService){}
ngOnInit(){
this.data.currentMessage.subscribe((m: string)=>{
this.message=m;
});
}
}
