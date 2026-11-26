import {Component} from '@angular/core';
import {AuthService} from '../auth';

@Component({
selector:'app-login',
standalone:false,
templateUrl:'./login.html'
})
export class LoginComponent{
constructor(public auth:AuthService){}
login(){
this.auth.login();
}
logout(){
this.auth.logout();
}
}