import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  standalone: false,
  styleUrl: './app.css'
})
export class App {
  name='Harry';
  age=23;
  city='Karanja';
  Show(){
    alert(`Name: ${this.name}, Age: ${this.age}, City: ${this.city}`);
  }
}
