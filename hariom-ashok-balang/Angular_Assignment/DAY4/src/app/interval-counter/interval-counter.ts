import { Component, OnInit } from '@angular/core';
import {interval} from 'rxjs';

@Component({
  selector: 'app-interval-counter',
  standalone: false,
  templateUrl: './interval-counter.html',
  styleUrl: './interval-counter.css',
})
export class IntervalCounterComponent implements OnInit{
count=0;
ngOnInit(){
interval(1000).subscribe(()=>{
this.count++;
});
}
}
