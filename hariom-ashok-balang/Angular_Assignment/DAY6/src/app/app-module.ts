import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { HomeComponent } from './home/home';
import { AboutComponent } from './about/about';
import { ProductListComponent } from './product-list/product-list';
import { ProductDetailsComponent } from './product-details/product-details';
import { LoginComponent } from './login/login';
import { DashboardComponent } from './dashboard/dashboard';
import { NotFoundComponent } from './not-found/not-found';

@NgModule({
  declarations: [
    App,
    HomeComponent,
    AboutComponent,
    ProductListComponent,
    ProductDetailsComponent,
    LoginComponent,
    DashboardComponent,
    NotFoundComponent,
  ],
  imports: [BrowserModule, AppRoutingModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
