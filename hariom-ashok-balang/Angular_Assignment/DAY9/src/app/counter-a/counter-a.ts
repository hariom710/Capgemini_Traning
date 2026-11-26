import {Component} from '@angular/core';
import {CounterService} from '../services/counter.service';

@Component({
selector:'app-counter-a',
templateUrl:'./counter-a.html',
standalone:false
})
export class CounterA{

constructor(public counter:CounterService){}

}