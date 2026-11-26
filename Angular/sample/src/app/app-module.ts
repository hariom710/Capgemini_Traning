import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Student } from './student/student';
import { CarComponent } from './car/car';
import { Person } from './person/person';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { Movieadd } from './movieadd/movieadd';
import { Reactform } from './reactform/reactform';
import { MypipePipe } from './mypipe-pipe';
import { Rx1 } from './rx1/rx1';
import { Search } from './search/search';
import { Sender } from './sender/sender';
import { Reciever } from './reciever/reciever';
import { Prodlist } from './prodlist/prodlist';
import { Home } from './home/home';

@NgModule({
  declarations: [
    App,
    Student,
    CarComponent,
    Person,
    Movieadd,
    Reactform,
    MypipePipe,
    Rx1,
    Search,
    Sender,
    Reciever,
    Prodlist,
    Home,
  ],
  imports: [BrowserModule, AppRoutingModule, FormsModule, ReactiveFormsModule],
  providers: [provideBrowserGlobalErrorListeners()],

  bootstrap: [App], //  bootstrap: [CarComponent, App, Student],
})
export class AppModule {}
