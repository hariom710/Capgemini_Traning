import {Component,OnInit} from '@angular/core';
import {ProductService} from '../services/product';

@Component({
  selector: 'app-product-list',
  standalone: false,
  templateUrl: './product-list.html',
  styleUrl: './product-list.css',
})
export class ProductListComponent implements OnInit{
products:any[]=[];
constructor(private service:ProductService){}
ngOnInit(){
this.service.getProducts().subscribe({
next: (data:any)=>{
console.log('Product API response:', data);
this.products=data;
},
error: (err)=>{
console.error('Product API error:', err);
}
});
}
}
