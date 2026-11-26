import { Component } from '@angular/core';
import { FormBuilder,Validators } from '@angular/forms';


@Component({
  selector: 'app-employee-form',
  standalone: false,
  templateUrl: './employee-form.html',
  styleUrl: './employee-form.css',
})
export class EmployeeForm {
  empForm;

  constructor(private fb:FormBuilder){
    this.empForm=this.fb.group({
      name:['',Validators.required],
      department:[''],
      salary:['',[Validators.required,Validators.min(1)]]
    });
  }
  data:any;
  submit(){
    this.data=this.empForm.value;
  }
}
