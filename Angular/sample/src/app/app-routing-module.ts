import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Movieadd } from './movieadd/movieadd';
import { Prodlist } from './prodlist/prodlist';
import { Reactform } from './reactform/reactform';
import { Student } from './student/student';
// import { Car } from './car';
import { CarComponent } from './car/car';


const routes: Routes = [
  {path:'', redirectTo: 'home', pathMatch: 'full'},
  {path:'addmovie', component:Movieadd},
  {path:'prodlist', component:Prodlist},
  {path:'reactform', component:Reactform},
  {path:'car/:id', component:CarComponent},
  {path:'**', component:Student},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
