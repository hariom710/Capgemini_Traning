import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductList } from './components/product-list/product-list';
import { ProductAdd } from './components/product-add/product-add';
import { ProductView } from './components/product-view/product-view';
import { ProductEdit } from './components/product-edit/product-edit';
import { ProductDelete } from './components/product-delete/product-delete';

const routes: Routes = [
  {path:"list",component:ProductList},
  {path:"add",component:ProductAdd},
  {path:"view/:id",component:ProductView},
  {path:"edit/:id",component:ProductEdit},
  {path:"delete/:id",component:ProductDelete},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
