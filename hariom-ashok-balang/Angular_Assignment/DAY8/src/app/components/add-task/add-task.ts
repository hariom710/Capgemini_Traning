import {Component} from '@angular/core';
import {TaskService} from '../../services/task.service';

@Component({
selector:'app-add-task',
templateUrl:'./add-task.html',
standalone:false
})
export class AddTask{
title='';
constructor(private service:TaskService){}
add(){
if(this.title.trim()){
this.service.addTask(this.title);
this.title='';
}
}
}