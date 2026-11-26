import { Component } from '@angular/core';

@Component({
  selector: 'app-login-status',
  standalone: false,
  templateUrl: './login-status.html',
  styleUrl: './login-status.css',
})
export class LoginStatus {
  isLoggedIn = true;
}
