import { Component } from '@angular/core';
import { DeptService } from '../../services/dept-service';
import { Idept } from '../../interfaces/idept';
import { ChangeDetectorRef } from '@angular/core';

@Component({
  selector: 'app-list',
  standalone: false,
  templateUrl: './list.html',
  styleUrl: './list.css',
})

export class List {
  deptData: Idept[] = []

  constructor(private deptService: DeptService, private cdr: ChangeDetectorRef) {
    this.deptService.getDept().subscribe((data) => {
      this.deptData = data;

      console.log(this.deptData);
      this.cdr.detectChanges();

    });
  }
}
