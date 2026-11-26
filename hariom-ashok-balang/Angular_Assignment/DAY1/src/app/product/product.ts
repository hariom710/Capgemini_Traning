import { Component } from '@angular/core';

@Component({
  selector: 'app-product',
  standalone: false,
  templateUrl: './product.html',
  styleUrl: './product.css',
})
export class ProductComponent {

 products = [
  {id:1,name:'Laptop',price:60000},
  {id:2,name:'Mobile',price:20000},
  {id:3,name:'Tablet',price:30000}
 ];

}