import { Component } from '@angular/core';

@Component({
  selector: 'app-course',
  standalone: false,
  templateUrl: './course.html',
  styleUrl: './course.css',
})
export class CourseComponent {

 courses = ["Angular","React","Vue","Django"];

}
