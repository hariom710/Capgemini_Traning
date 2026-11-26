import {Component} from '@angular/core';
import {CounterService} from '../services/counter.service';


@Component({
selector:'app-counter-b',
templateUrl:'./counter-b.html',
standalone:false
})
export class CounterB{

constructor(public counter:CounterService){}

}