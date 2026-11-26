import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';


@Component({
  selector: 'app-student-form',
  standalone: false,
  templateUrl: './student-form.html',
  styleUrl: './student-form.css',
})
export class StudentForm {
  studentForm=new FormGroup({
    roll:new FormControl('',Validators.required),
    name:new FormControl('',Validators.required),
    course:new FormControl('',Validators.required)
  });
  data:any;
  submit(){
    this.data=this.studentForm.value;
  }
}
