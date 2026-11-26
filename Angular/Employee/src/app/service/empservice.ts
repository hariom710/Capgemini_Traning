import { Injectable } from '@angular/core';
import { Iemp } from '../interface/iemp';

@Injectable({
  providedIn: 'root',
})
export class Empservice {
  empdata:Iemp[] = [];
  ngOnInit(){
    this.empdata = [
      { 'id': 111, 'name': 'Harry', 'mobile': 1234567890, 'email': 'john.doe@company.com', 'city': 'New York' },
      { 'id': 222, 'name': 'Hari', 'mobile': 6987654321, 'email': 'jane.smith@company.com', 'city': 'Los Angeles' },
      { 'id': 333, 'name': 'Hariom', 'mobile': 1122334455, 'email': 'michael.johnson@company.com', 'city': 'Chicago' },
      { 'id': 444, 'name': 'Shriom', 'mobile': 5544332211, 'email': 'emily.davis@company.com', 'city': 'Houston' },
      { 'id': 555, 'name': 'Om', 'mobile': 9988776655, 'email': 'david.wilson@company.com', 'city': 'Phoenix' }
    ];
  }
  getEmployeeList(){
    if(this.empdata.length == 0){
      this.ngOnInit();
    }
    return this.empdata;
  }

  getEmployeeById(id:number){
    if(this.empdata.length == 0){
      this.ngOnInit();
    }
    return this.empdata.find(emp => emp.id === id);
  }
}
