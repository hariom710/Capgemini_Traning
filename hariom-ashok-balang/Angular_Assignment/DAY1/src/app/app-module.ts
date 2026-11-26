import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { StudentComponent } from './student/student';
import { ProductComponent } from './product/product';
import { LoginComponent } from './login/login';
import { CounterComponent } from './counter/counter';
import { CourseComponent } from './course/course';

@NgModule({
  declarations: [App, StudentComponent, ProductComponent, LoginComponent, CounterComponent, CourseComponent],
  imports: [BrowserModule, AppRoutingModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
