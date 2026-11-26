import { Component } from '@angular/core';

@Component({
  selector: 'app-student',
  standalone: false,
  templateUrl: './student.html',
  styleUrl: './student.css',
})
export class Student {
  name='Tom';
  rollNo=101;
  sub1=80;
  sub2=90;
  sub3=85;
calcTotal():number{
  return this.sub1 + this.sub2 + this.sub3;
}

calcAverage():number{
  return this.calcTotal() / 3;
}

calcGrade():string{
  const avg = this.calcAverage();
  if(avg >= 90){
    return 'A';
  } else if(avg >= 80){
    return 'B';
  } else if(avg >= 70){
    return 'C';
  } else if(avg >= 60){
    return 'D';
  } else {
    return 'F';
  }
}
}
