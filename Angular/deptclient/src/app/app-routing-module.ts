import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { List } from './components/list/list';
import { Edit } from './components/edit/edit';
import { Find } from './components/find/find';
import { Add } from './components/add/add';
import { Delete } from './components/delete/delete';

const routes: Routes = [
  { path: "list", component: List },
  { path: "add", component: Add },
  { path: "delete/:id", component: Delete },
  { path: "edit/:id", component: Edit },
  { path: "find/:id", component: Find }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
