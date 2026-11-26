import {NgModule} from '@angular/core';
import {RouterModule,Routes} from '@angular/router';
import {HomeComponent} from './home/home';
import {AboutComponent} from './about/about';
import {ProductListComponent} from './product-list/product-list';
import {ProductDetailsComponent} from './product-details/product-details';
import {LoginComponent} from './login/login';
import {DashboardComponent} from './dashboard/dashboard';
import {NotFoundComponent} from './not-found/not-found';

const routes:Routes=[
{path:'home',component:HomeComponent},
{path:'about',component:AboutComponent},
{path:'products',component:ProductListComponent},
{path:'products/details',component:ProductDetailsComponent},
{path:'product/:id',component:ProductDetailsComponent},
{path:'login',component:LoginComponent},
{path:'dashboard',component:DashboardComponent},
{path:'',redirectTo:'home',pathMatch:'full'},
{path:'**',component:NotFoundComponent}
];

@NgModule({
imports:[RouterModule.forRoot(routes)],
exports:[RouterModule]
})
export class AppRoutingModule{}