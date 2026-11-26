import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Idept } from '../interfaces/idept';
import { Observable  } from 'rxjs';
import { HttpErrorResponse } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { catchError } from 'rxjs';
import { throwError } from 'rxjs';

@Injectable({
  providedIn: 'root',
})

export class DeptService {
  url = "http://localhost:5004/api/Dept/"
  httpoptions = { headers: new HttpHeaders({ 'content-type': 'application/json' }) }

  constructor(private httpClient: HttpClient) { }

  getDept(): Observable<Idept[]>;
  getDept(id: number): Observable<Idept>;
  getDept(id?: number): Observable<Idept[] | Idept> {
    if (id === undefined) {
      return this.httpClient.get<Idept[]>(this.url + 'ListDepts');
    }

    return this.httpClient.get<Idept>(this.url + 'ListDepts/' + id).pipe(catchError(this.handleError));
  }

  addDept(dept:Idept):Observable<Idept>{
    return this.httpClient.post<Idept>(this.url+'AddDept',dept,this.httpoptions).pipe(catchError(this.handleError))
  }

  editDept(dept:Idept):Observable<Idept>{
    return this.httpClient.put<Idept>(this.url+'EditDept',dept,this.httpoptions).pipe(catchError(this.handleError))
  }

  deleteDept(id:number):Observable<Idept>{
    return this.httpClient.delete<Idept>(this.url+'DeleteDept/'+id).pipe(catchError(this.handleError))
  }

  handleError(error: HttpErrorResponse) {
    let msg = '';

    msg = error.status + '\n' + error.statusText + '\n' + error.error;
    alert(msg);

    return throwError(() => msg);
  }
}
