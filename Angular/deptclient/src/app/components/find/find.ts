import { Component } from '@angular/core';
import { Idept } from '../../interfaces/idept';
import { DeptService } from '../../services/dept-service';
import { ActivatedRoute } from '@angular/router';
import { ChangeDetectorRef } from '@angular/core';

@Component({
  selector: 'app-find',
  standalone: false,
  templateUrl: './find.html',
  styleUrl: './find.css',
})

export class Find {
  deptData: Idept = { id: 0, name: '', location: '' };
  id: number = 0;

  constructor(private deptService: DeptService, private activatedRoute: ActivatedRoute, private cdr: ChangeDetectorRef) { }

  ngOnInit(): void {
    const tid = this.activatedRoute.snapshot.paramMap.get('id');

    this.id = Number(tid);
    this.deptService.getDept(this.id).subscribe((data: Idept) => {
      this.deptData = data;
      console.log(this.deptData);
      this.cdr.detectChanges();

    });

  }


}
