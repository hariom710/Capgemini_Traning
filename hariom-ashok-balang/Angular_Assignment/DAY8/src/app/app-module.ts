import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { AddTask } from './components/add-task/add-task';
import { TaskList } from './components/task-list/task-list';
import { TaskItem } from './components/task-item/task-item';
import { TaskStats } from './components/task-stats/task-stats';

@NgModule({
  declarations: [App, AddTask, TaskList, TaskItem, TaskStats],
  imports: [BrowserModule, FormsModule, AppRoutingModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
