import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Cart } from './cart/cart';
import { Prodlist } from './prodlist/prodlist';
import { Signaldemo } from './signaldemo/signaldemo';
import { Appcart } from './appcart/appcart';

@NgModule({
  declarations: [App, Cart, Prodlist, Signaldemo, Appcart],
  imports: [BrowserModule, AppRoutingModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
