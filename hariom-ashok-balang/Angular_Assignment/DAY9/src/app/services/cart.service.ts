import {Injectable} from '@angular/core';

@Injectable({providedIn:'root'})
export class CartService{

cart:any[]=[];

addToCart(product:any){
this.cart.push(product);
}

removeFromCart(id:number){
this.cart=this.cart.filter(p=>p.id!==id);
}

getCartItems(){
return this.cart;
}

getCount(){
return this.cart.length;
}

}
