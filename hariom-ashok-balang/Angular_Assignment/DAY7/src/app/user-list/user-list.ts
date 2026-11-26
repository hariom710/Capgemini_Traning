import {Component,OnInit} from '@angular/core';
import {UserService} from '../services/user';

@Component({
  selector: 'app-user-list',
  standalone: false,
  templateUrl: './user-list.html',
  styleUrl: './user-list.css',
})
export class UserListComponent implements OnInit{
users:any[]=[];
constructor(private service:UserService){}
ngOnInit(){
this.service.getUsers().subscribe({
next: (data:any)=>{
console.log('User API response:', data);
this.users=data;
},
error: (err)=>{
console.error('User API error:', err);
}
});
}
}
