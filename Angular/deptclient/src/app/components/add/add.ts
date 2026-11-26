import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Idept } from '../../interfaces/idept';
import { DeptService } from '../../services/dept-service';

@Component({
  selector: 'app-add',
  standalone: false,
  templateUrl: './add.html',
  styleUrl: './add.css',
})

export class Add {
  deptData:Idept = {id:0,name:'',location:''};

  constructor(private deptService: DeptService,private activatedRoute: ActivatedRoute, private router: Router) {}

  save(dept:Idept){
    this.deptService.addDept(this.deptData).subscribe(()=> alert("Department Added Successfully"));
    this.router.navigate(['/list']);
  }
}
