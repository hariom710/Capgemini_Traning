import {Injectable} from '@angular/core';
import {TaskService} from './task.service';

@Injectable({providedIn:'root'})
export class StatsService{

constructor(private taskService:TaskService){}

getTotal(){
return this.taskService.getTasks().length;
}

getCompleted(){
return this.taskService.getTasks().filter(t=>t.completed).length;
}

getPending(){
return this.getTotal()-this.getCompleted();
}
}