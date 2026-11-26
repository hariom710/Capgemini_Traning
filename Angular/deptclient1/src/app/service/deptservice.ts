import { Injectable } from '@angular/core';
import { Idept } from '../interface/idept';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { HttpHeaderResponse } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { catchError } from 'rxjs';
import { throwError } from 'rxjs';



@Injectable({
  providedIn: 'root',
})
export class Deptservice {
  url="http://localhost:5198/api/Dept";
  httpOptions={
    headers:new HttpHeaders({
      'Content-Type':'application/json'
    })
  }
  constructor(private httpclient:HttpClient) {}

  getDeptList(): Observable<Idept[]> {
    return this.httpclient.get<Idept[]>(this.url+'ListDept');
  }
}
