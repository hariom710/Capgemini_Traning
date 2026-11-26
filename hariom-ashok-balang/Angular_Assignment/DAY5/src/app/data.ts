import {Injectable} from '@angular/core';
import {BehaviorSubject} from 'rxjs';

@Injectable({providedIn:'root'})
export class DataService{
private message=new BehaviorSubject<string>('Hello');
currentMessage=this.message.asObservable();
updateMessage(msg:string){
this.message.next(msg);
}
}