import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Empservice } from '../service/empservice';
import { Iemp } from '../interface/iemp';
import { Router } from '@angular/router';


@Component({
  selector: 'app-emplist',
  imports: [CommonModule],
  templateUrl: './emplist.html',
  styleUrl: './emplist.css',
})
export class Emplist {
  empdata: Iemp[] = [];
  constructor(private empservice: Empservice, private router: Router) {
  }
  ngOnInit() {
    this.empdata = this.empservice.getEmployeeList();

  }
  navigateUrl(path:string,id:number){
    this.router.navigate([path,id]);
  }
}
