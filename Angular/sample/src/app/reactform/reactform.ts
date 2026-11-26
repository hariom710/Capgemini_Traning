import { Component } from '@angular/core';
import { Imovie } from '../imovie';
import { FormControl, Validators, FormGroup, MaxValidator } from '@angular/forms';


@Component({
  selector: 'app-reactform',
  standalone: false,
  templateUrl: './reactform.html',
  styleUrl: './reactform.css',
})
export class Reactform {
  moviedata: Imovie = {
    id: 0,
    name: '',
    ratings: 0,
    year: 0
  };

  

  
    movieForm = new FormGroup({
    id: new FormControl(0, Validators.required),
    name: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z ]*$')]),
    ratings: new FormControl(0, [Validators.min(0), Validators.max(10)]),
    year: new FormControl(0, [Validators.min(1900), Validators.max(2026)])

    });
  

  submitdata() {
    console.log(this.movieForm.value);
  }
}
