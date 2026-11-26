import {Component} from '@angular/core';
import {StatsService} from '../../services/stats.service';

@Component({
selector:'app-task-stats',
templateUrl:'./task-stats.html',
standalone:false
})
export class TaskStats{
constructor(public stats:StatsService){}
}