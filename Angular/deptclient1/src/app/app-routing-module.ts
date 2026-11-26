import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { List } from './component/list/list';

const routes: Routes = [
  { path : 'list' ,  component : List }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
