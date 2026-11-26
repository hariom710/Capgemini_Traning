import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class WeatherService{
constructor(private http:HttpClient){}
getWeather(){
return this.http.get<any>('https://api.open-meteo.com/v1/forecast?latitude=28.6&longitude=77.2&current_weather=true');
}
}
