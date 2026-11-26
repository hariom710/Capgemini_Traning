import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Empservice } from '../service/empservice';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-empdetails',
  imports: [CommonModule],
  templateUrl: './empdetails.html',
  styleUrl: './empdetails.css',
})
export class Empdetails {
  employee: any = {};
  id: number = 0;
  constructor( private empservice: Empservice, private activateroute: ActivatedRoute) {
  }
  ngOnInit() {
    const id = this.activateroute.snapshot.params['id'];
    this.id = Number(id);
    this.employee = this.empservice.getEmployeeById(this.id);
  }
}
