import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { DashboardComponent } from './dashboard/dashboard';
import { ProductComponent } from './product/product';
import { LoginComponent } from './login/login';
import { SenderComponent } from './sender/sender';
import { ReceiverComponent } from './receiver/receiver';
import { UserComponent } from './user/user';

@NgModule({
  declarations: [App, DashboardComponent, ProductComponent, LoginComponent, SenderComponent, ReceiverComponent, UserComponent],
  imports: [BrowserModule, HttpClientModule, AppRoutingModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
