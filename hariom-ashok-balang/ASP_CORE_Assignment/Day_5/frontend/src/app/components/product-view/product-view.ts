import { Component } from '@angular/core';
import { Productservice } from '../../service/productservice';
import { Iproduct } from '../../interface/iproduct';
import { ActivatedRoute } from '@angular/router';
import { ChangeDetectorRef } from '@angular/core';
@Component({
  selector: 'app-product-view',
  standalone: false,
  templateUrl: './product-view.html',
  styleUrl: './product-view.css',
})
export class ProductView {
  product: Iproduct = {
    id: 0,
    name: '',
    price: 0,
    category: '',
  };

  constructor(private productService: Productservice, private activatedRoute: ActivatedRoute, private cdr: ChangeDetectorRef){}

  ngOnInit(){
    this.activatedRoute.params.subscribe(params => {
      const id = +params['id'];
      this.productService.getProductById(id).subscribe(product => {
        this.product = product;
        this.cdr.detectChanges();
      });
    });
  }
}