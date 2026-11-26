import {Component,OnInit} from '@angular/core';
import {ApiService} from '../api';

interface User {
id: number;
name: string;
email: string;
}

@Component({
  selector: 'app-user',
  standalone: false,
  templateUrl: './user.html',
  styleUrl: './user.css',
})
export class UserComponent implements OnInit{
users: User[] = [];
errorMessage = '';
constructor(private api: ApiService){}
ngOnInit(){
this.api.getUsers().subscribe({
next: (data: User[]) => {
this.users = data;
this.errorMessage = '';
},
error: () => {
this.errorMessage = 'Could not load users from the API. Showing sample data instead.';
this.users = [
{ id: 1, name: 'Leanne Graham', email: 'Sincere@april.biz' },
{ id: 2, name: 'Ervin Howell', email: 'Shanna@melissa.tv' },
{ id: 3, name: 'Clementine Bauch', email: 'Nathan@yesenia.net' }
];
}
});
}
}
