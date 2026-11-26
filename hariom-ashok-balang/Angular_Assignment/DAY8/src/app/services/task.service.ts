import {Injectable} from '@angular/core';
import {Task} from '../models/task.model';
import {LoggingService} from './logging.service';

@Injectable({providedIn:'root'})
export class TaskService{

tasks:Task[]=[];
idCounter=1;

constructor(private logger:LoggingService){}

getTasks(){
return this.tasks;
}

addTask(title:string){
this.tasks.push({id:this.idCounter++,title:title,completed:false});
this.logger.log('Task Added:'+title);
}

deleteTask(id:number){
this.tasks=this.tasks.filter(t=>t.id!==id);
this.logger.log('Task Deleted:'+id);
}

toggleTask(id:number){
this.tasks=this.tasks.map(t=>{
if(t.id===id){t.completed=!t.completed;}
return t;
});
this.logger.log('Task Toggled:'+id);
}
}
