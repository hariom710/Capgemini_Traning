import { Component } from '@angular/core';
import { Productservice } from '../productservice';
import { Observable, tap } from 'rxjs';

@Component({
  selector: 'app-prodlist',
  standalone: false,
  templateUrl: './prodlist.html',
  styleUrl: './prodlist.css',
})
export class Prodlist {
  productslist$!: Observable<any[]>;
  
  constructor(private productservice: Productservice) {}

  ngOnInit() {
    this.productslist$ = this.productservice
      .getProducts()
      .pipe(tap((data) => console.log(data)));
  }
}
