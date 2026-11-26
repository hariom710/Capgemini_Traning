import { Component } from '@angular/core';

@Component({
  selector: 'app-product-view',
  standalone: false,
  templateUrl: './product-view.html',
  styleUrl: './product-view.css',
})
export class ProductView {
  productName = "Smart Watch";

  imageUrl = "smartwatch1.jpg";
}
