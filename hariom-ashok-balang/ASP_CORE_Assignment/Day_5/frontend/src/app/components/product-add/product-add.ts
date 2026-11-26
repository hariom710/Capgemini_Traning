import { Component } from '@angular/core';
import { Productservice } from '../../service/productservice';
import { Iproduct } from '../../interface/iproduct';
import { Router } from '@angular/router';
import { FormGroup,FormControl, Validators } from '@angular/forms';
@Component({
  selector: 'app-product-add',
  standalone: false,
  templateUrl: './product-add.html',
  styleUrl: './product-add.css',
})
export class ProductAdd {

  productForm: FormGroup = new FormGroup  ({
    name: new FormControl('',Validators.required),
    price: new FormControl(0,Validators.required),
    category: new FormControl('',Validators.required)
  });

  product: Iproduct = {
    id: 0,
    name: '',
    price: 0,
    category: '',
  };

  constructor(private productService: Productservice, private router: Router) {}

  addProduct(product: Iproduct){
    this.productService.addProduct(product).subscribe(() => {
      console.log("Product Added Successfully");
      this.router.navigate(['/list']);
    });
  }
}
