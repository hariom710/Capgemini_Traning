import {Component} from '@angular/core';
import {CartService} from '../services/cart.service';

@Component({
selector:'app-cart',
templateUrl:'./cart.html',
standalone:false
})
export class Cart{

constructor(public cart:CartService){}

remove(id:number){
this.cart.removeFromCart(id);
}

}