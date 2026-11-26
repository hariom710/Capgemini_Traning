import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Cart } from './cart/cart';
import { Prodlist } from './prodlist/prodlist';

const routes: Routes = [
  { path: '', component: Prodlist },
  { path: 'cart', component: Cart },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
