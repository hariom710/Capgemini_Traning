import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Navbar } from './components/navbar/navbar';
import { ProductList } from './components/product-list/product-list';
import { ProductView } from './components/product-view/product-view';
import { ProductDelete } from './components/product-delete/product-delete';
import { ProductEdit } from './components/product-edit/product-edit';
import { ProductAdd } from './components/product-add/product-add';

@NgModule({
  declarations: [App, Navbar, ProductList, ProductView, ProductDelete, ProductEdit, ProductAdd],
  imports: [BrowserModule, AppRoutingModule, ReactiveFormsModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
