import { Component, OnInit } from '@angular/core';
import {ProductService} from '../product';

@Component({
  selector: 'app-product-list',
  standalone: false,
  templateUrl: './product-list.html',
  styleUrl: './product-list.css',
})
export class ProductListComponent implements OnInit{
products:any[]=[];
constructor(private productService:ProductService){}
ngOnInit(){
this.productService.getProducts().subscribe(data=>{
this.products=data;
});
}
}
