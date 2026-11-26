import { Component } from '@angular/core';

@Component({
  selector: 'app-product-list',
  standalone: false,
  templateUrl: './product-list.html',
  styleUrl: './product-list.css',
})
export class ProductListComponent{
products=[
{id:1,name:'Laptop'},
{id:2,name:'Mobile'},
{id:3,name:'Headphones'}
];
}
