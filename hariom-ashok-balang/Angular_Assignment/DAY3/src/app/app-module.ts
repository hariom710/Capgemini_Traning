import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { UserRegistration } from './user-registration/user-registration';
import { LoginForm } from './login-form/login-form';
import { StudentForm } from './student-form/student-form';
import { EmployeeForm } from './employee-form/employee-form';
import { FeedbackForm } from './feedback-form/feedback-form';

@NgModule({
  declarations: [App, UserRegistration, LoginForm, StudentForm, EmployeeForm, FeedbackForm],
  imports: [BrowserModule, AppRoutingModule, FormsModule, ReactiveFormsModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
