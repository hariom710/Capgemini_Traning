import { Component } from '@angular/core';

@Component({
  selector: 'app-user-registration',
  standalone: false,
  templateUrl: './user-registration.html',
  styleUrl: './user-registration.css',
})
export class UserRegistration {
  user={name:'',email:'',password:''};
  submitted=false;
  onSubmit(){
    this.submitted=true;
  }
}
