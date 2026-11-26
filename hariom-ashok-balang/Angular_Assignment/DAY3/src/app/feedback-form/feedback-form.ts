import { Component } from '@angular/core';
import { FormGroup,FormControl,Validators } from '@angular/forms';



@Component({
  selector: 'app-feedback-form',
  standalone: false,
  templateUrl: './feedback-form.html',
  styleUrl: './feedback-form.css',
})
export class FeedbackForm {
   success=false;
  feedbackForm=new FormGroup({
    name:new FormControl('',Validators.required),
    email:new FormControl('',[Validators.required,Validators.email]),
    message:new FormControl('',Validators.required)
  });
  submit(){
    if(this.feedbackForm.valid){
      this.success=true;
    }
  }
}
