import { Component } from '@angular/core';
import { Car } from '../car';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-car',
  standalone: false,
  templateUrl: './car.html',
  styleUrl: './car.css',
})
export class CarComponent {
  cars: Car[] = [
    new Car('Toyota Camry', 2020, 'Red'),
    new Car('Honda Accord', 2019, 'Blue'),
    new Car('Ford Mustang', 2021, 'Black'),
  ];
  id: number=0;
  constructor(private activateroute: ActivatedRoute) {}
 
  ngOnInit() {
    this.id=this.activateroute.snapshot.params['id'];
  }
}
