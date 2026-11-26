import { Component } from '@angular/core';

@Component({
  selector: 'app-student',
  standalone: false,
  templateUrl: './student.html',
  styleUrl: './student.css',
})
export class StudentComponent {
  rollNo: number = 1;
  name: string = "Hariom";
  course: string = "Computer Technology";
  percentage: number = 90;
}
