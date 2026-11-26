import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { UserProfile } from './user-profile/user-profile';
import { ProductView } from './product-view/product-view';
import { ClickCounter } from './click-counter/click-counter';
import { StudentList } from './student-list/student-list';
import { LoginStatus } from './login-status/login-status';

@NgModule({
  declarations: [App, UserProfile, ProductView, ClickCounter, StudentList, LoginStatus],
  imports: [BrowserModule, AppRoutingModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
