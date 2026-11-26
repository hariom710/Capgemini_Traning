import { Component, OnInit } from '@angular/core';
import {Logger} from '../logger';

@Component({
  selector: 'app-dashboard',
  standalone: false,
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.css',
})
export class DashboardComponent implements OnInit{
constructor(private logger:Logger){}
ngOnInit(){
this.logger.log('Dashboard component loaded');
}
}
