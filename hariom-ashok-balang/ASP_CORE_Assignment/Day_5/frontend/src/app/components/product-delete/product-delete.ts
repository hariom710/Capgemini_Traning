import { Component } from '@angular/core';
import { Productservice } from '../../service/productservice';
import { Iproduct } from '../../interface/iproduct';
import { ActivatedRoute } from '@angular/router';
import { ChangeDetectorRef } from '@angular/core';
import { FormGroup,FormControl } from '@angular/forms';
import { Router } from '@angular/router';
@Component({
  selector: 'app-product-delete',
  standalone: false,
  templateUrl: './product-delete.html',
  styleUrl: './product-delete.css',
})
export class ProductDelete {
  product: Iproduct = {
    id: 0,
    name: '',
    price: 0,
    category: '',
   };

  constructor(private productService: Productservice, private activatedRoute: ActivatedRoute, private cdr: ChangeDetectorRef, private router: Router){}

  private id: number = 0;

  ngOnInit(){
    this.activatedRoute.params.subscribe(params => {
      this.id= +params['id'];
      this.productService.getProductById(this.id).subscribe(product => {
        this.product = product;
        this.cdr.detectChanges();
      });
    });
  }
  
  deleteProduct(id: number){
    this.productService.deleteProduct(id).subscribe(() => {
      console.log("Product Deleted Successfully");
      this.router.navigate(['/list']);
    });
  }
}
