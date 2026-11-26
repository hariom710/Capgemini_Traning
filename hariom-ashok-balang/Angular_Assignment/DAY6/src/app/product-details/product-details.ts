import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from '@angular/router';

@Component({
  selector: 'app-product-details',
  standalone: false,
  templateUrl: './product-details.html',
  styleUrl: './product-details.css',
})
export class ProductDetailsComponent implements OnInit{
id:any;
constructor(private route:ActivatedRoute){}
ngOnInit(){
this.id=this.route.snapshot.paramMap.get('id');
}
}