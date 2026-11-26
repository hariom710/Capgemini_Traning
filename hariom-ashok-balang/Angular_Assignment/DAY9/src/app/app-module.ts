import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { ProductList } from './product-list/product-list';
import { Cart } from './cart/cart';
import { CounterA } from './counter-a/counter-a';
import { CounterB } from './counter-b/counter-b';

@NgModule({
  declarations: [App, ProductList, Cart, CounterA, CounterB],
  imports: [BrowserModule, AppRoutingModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
