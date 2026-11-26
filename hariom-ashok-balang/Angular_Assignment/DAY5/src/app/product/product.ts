import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product';

@Component({
  selector: 'app-product',
  standalone: false,
  templateUrl: './product.html',
  styleUrl: './product.css',
})
export class ProductComponent implements OnInit{
products:any[]=[];
constructor(private productService:ProductService){}
ngOnInit(){
this.products=this.productService.getProducts();
}
}
