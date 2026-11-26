import { Injectable } from '@angular/core';
import { Iproduct } from '../interface/iproduct';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root',
})
export class Productservice {
  constructor(private http: HttpClient) {}
  private url = 'http://localhost:5024/api/Products/';

  getProducts(){
    return this.http.get<Iproduct[]>(this.url+'GetProducts');
  }

  getProductById(id: number){
    return this.http.get<Iproduct>(this.url+'GetProductById/'+id);
  }
  
  addProduct(product: Iproduct){
    return this.http.post(this.url+'AddProduct', product);
  }

  updateProduct(id: number, product: Iproduct){
    return this.http.put(this.url+'UpdateProduct/'+id, product);
  }
  
  deleteProduct(id: number){
    return this.http.delete(this.url+'DeleteProduct/'+id, {responseType: 'text'});
  }
}
