import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class Dataservice {
  private messageSource = new BehaviorSubject<string>('Hello from Dataservice!');
  public data$ = this.messageSource.asObservable();

  constructor() {}

  updateMessage(newMessage: string) {
    this.messageSource.next(newMessage);
  }
}
