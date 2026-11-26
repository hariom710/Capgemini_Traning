import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { ProductListComponent } from './product-list/product-list';
import { UserListComponent } from './user-list/user-list';
import { WeatherComponent } from './weather/weather';

@NgModule({
  declarations: [App, ProductListComponent, UserListComponent, WeatherComponent],
  imports: [BrowserModule, HttpClientModule, AppRoutingModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
