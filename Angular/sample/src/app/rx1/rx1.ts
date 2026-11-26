import { Component } from '@angular/core';
import { Observable,of } from 'rxjs';
import { map } from 'rxjs/operators';
import { OnInit } from '@angular/core';

@Component({
  selector: 'app-rx1',
  standalone: false,
  templateUrl: './rx1.html',
  
  styleUrl: './rx1.css',

})
export class Rx1 implements OnInit {

  odata:number[]=[];
  ngOnInit(): void {
    const data = of(1, 2, 3, 4, 5);
    data.pipe(map(x => x * 2)).subscribe(res => this.odata.push(res));
  }
  
}
