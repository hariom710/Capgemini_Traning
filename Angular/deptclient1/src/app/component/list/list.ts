import { Component } from '@angular/core';
import { Deptservice } from '../../service/deptservice';
import { Idept } from '../../interface/idept';


@Component({
  selector: 'app-list',
  standalone: false,
  templateUrl: './list.html',
  styleUrl: './list.css',
})
export class List {
  deptdata: Idept[] = [];
  constructor(private deptservice: Deptservice) {
    this.deptservice.getDeptList().subscribe((data) => {
      this.deptdata = data;
    });
  }

}
