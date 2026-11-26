import { Component } from '@angular/core';

@Component({
  selector: 'app-person',
  standalone: false,
  templateUrl: './person.html',
  styleUrls: ['./person.css']
  // template: '<div> <h2>{{ name }}</h2> <p>Age: {{ age }}</p> </div>',
  // styles: `h2 { border:1px solid #ccc; padding: 10px; margin: 16px; }`
})
export class Person {
  name: string = 'John Doe';
  age: number = 30;
  city:string='mumbai';
  phone:string='1234567890';
  isRedEnabled: boolean = true;
  ShowDetails:boolean=false
  ToggleDetails(){
    this.ShowDetails=!this.ShowDetails
  }

  weekdays: string[] = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'];
  

}
