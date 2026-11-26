import {Component,Input} from '@angular/core';
import {Task} from '../../models/task.model';
import {TaskService} from '../../services/task.service';

@Component({
selector:'app-task-item',
templateUrl:'./task-item.html',
standalone:false
})
export class TaskItem{

@Input() task!:Task;

constructor(private service:TaskService){}

toggle(){
this.service.toggleTask(this.task.id);
}

delete(){
this.service.deleteTask(this.task.id);
}
}