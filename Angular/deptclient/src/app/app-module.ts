import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { List } from './components/list/list';
import { Add } from './components/add/add';
import { Delete } from './components/delete/delete';
import { Edit } from './components/edit/edit';
import { Find } from './components/find/find';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [App, List, Add, Delete, Edit, Find],
  imports: [BrowserModule, AppRoutingModule, FormsModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
