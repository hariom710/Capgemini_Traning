import { Component, OnInit } from '@angular/core';
import {of} from 'rxjs';
import {filter} from 'rxjs/operators';

@Component({
  selector: 'app-number-filter',
  standalone: false,
  templateUrl: './number-filter.html',
  styleUrl: './number-filter.css',
})
export class NumberFilterComponent implements OnInit{
numbers:number[]=[];
ngOnInit(){
of(1,2,3,4,5,6,7,8).pipe(filter(x=>x%2===0)).subscribe(val=>{
this.numbers.push(val);
});
}
}
