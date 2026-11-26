import { Routes } from '@angular/router';
import { Emplist } from './emplist/emplist';
import { Empdetails } from './empdetails/empdetails';


export const routes: Routes = [
  { path: 'list', component: Emplist },
  { path: 'empdetails/:id', component: Empdetails }
];
