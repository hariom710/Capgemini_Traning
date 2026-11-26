import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Counter } from './counter/counter';
import { Student } from './student/student';
import { Home } from './home/home';
import { About } from './about/about';
import { Contact } from './contact/contact';
import { Users } from './users/users';

@NgModule({
  declarations: [App, Counter, Student, Home, About, Contact, Users],
  imports: [BrowserModule, AppRoutingModule, ReactiveFormsModule, HttpClientModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
