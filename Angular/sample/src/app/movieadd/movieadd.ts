import { Component } from '@angular/core';
import { Imovie } from '../imovie';

@Component({
  selector: 'app-movieadd',
  standalone: false,
  templateUrl: './movieadd.html',
  styleUrl: './movieadd.css',
})
export class Movieadd {
  moviedata:Imovie={id:0,name:'',ratings:0,year:0}

  savedata(data:Imovie){
    console.log(data)
  }
}
