import { Component } from '@angular/core';
import { Productservice } from '../../service/productservice';
import { ChangeDetectorRef } from '@angular/core';
@Component({
  selector: 'app-product-list',
  standalone: false,
  templateUrl: './product-list.html',
  styleUrl: './product-list.css',
})
export class ProductList {
  products: any[] = [];

  constructor(private productService: Productservice,private cdr:ChangeDetectorRef) {}

  ngOnInit() {
    this.productService.getProducts().subscribe((data) => {
      this.products = data;
      console.log(data)
      this.cdr.detectChanges();
    });
  }
}
