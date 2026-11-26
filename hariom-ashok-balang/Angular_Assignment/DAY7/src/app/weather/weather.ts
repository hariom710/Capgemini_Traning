import {Component,OnInit} from '@angular/core';
import {WeatherService} from '../services/weather';

@Component({
  selector: 'app-weather',
  standalone: false,
  templateUrl: './weather.html',
  styleUrl: './weather.css',
})
export class WeatherComponent implements OnInit{
weather:any;
constructor(private service:WeatherService){}
ngOnInit(){
this.service.getWeather().subscribe({
next: (data:any)=>{
console.log('Weather API response:', data);
this.weather=data.current_weather;
},
error: (err)=>{
console.error('Weather API error:', err);
}
});
}
}
