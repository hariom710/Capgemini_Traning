import {Component} from '@angular/core';
import {TaskService} from '../../services/task.service';

@Component({
selector:'app-task-list',
templateUrl:'./task-list.html',
standalone:false
})
export class TaskList{
constructor(public service:TaskService){}
}