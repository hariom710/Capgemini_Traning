import { Component } from '@angular/core';
import { Productservice } from '../../service/productservice';
import { Iproduct } from '../../interface/iproduct';
import { ActivatedRoute } from '@angular/router';
import { ChangeDetectorRef } from '@angular/core';
import { FormGroup,FormControl } from '@angular/forms';
import { Router } from '@angular/router';
@Component({
  selector: 'app-product-edit',
  standalone: false,
  templateUrl: './product-edit.html',
  styleUrl: './product-edit.css',
})
export class ProductEdit {
  productForm: FormGroup = new FormGroup  ({
    id: new FormControl(0),
    name: new FormControl(''),
    price: new FormControl(0),
    category: new FormControl('')
  });

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
        this.productForm.patchValue({
          id: product.id,
          name: product.name,
          price: product.price,
          category: product.category
        });
        this.cdr.detectChanges();
      });
    });
  }
  
  updateProduct(product: Iproduct){
    this.productService.updateProduct(this.id, product).subscribe(() => {
      console.log("Product Updated Successfully");
      this.router.navigate(['/list']);
    });
  }
}
