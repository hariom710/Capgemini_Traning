import {Component} from '@angular/core';
import {CartService} from '../services/cart.service';

@Component({
selector:'app-product-list',
templateUrl:'./product-list.html',
standalone:false
})
export class ProductList{

products=[
{id:1,name:'Laptop'},
{id:2,name:'Mobile'},
{id:3,name:'Headphones'}
];

constructor(private cart:CartService){}

add(p:any){
this.cart.addToCart(p);
}

}