import { Component } from '@angular/core';

interface StudentData {
  id: number;
  name: string;
  department: string;
  email: string;
}

@Component({
  selector: 'app-student',
  standalone: false,
  templateUrl: './student.html',
  styleUrl: './student.css',
})
export class Student {
  students: StudentData[] = [
    { id: 1,name: 'Hariom', department: 'cse' ,email: 'hariom@example.com'},
    { id: 2, name: 'Harry', department: 'ETC' ,email: 'harry@example.com'},
    { id: 3, name: 'Alice', department: 'Mechanical' ,email: 'alice@example.com'},
    { id: 4, name: 'Parth', department: 'Civil' ,email: 'parth@example.com'},
    { id: 5, name: 'Aditya', department: 'IT' ,email: 'aditya@example.com'},
  ];
}
