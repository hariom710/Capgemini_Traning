import { Component, OnInit } from '@angular/core';
import {Subject} from 'rxjs';
import {debounceTime,distinctUntilChanged} from 'rxjs/operators';

@Component({
  selector: 'app-search',
  standalone: false,
  templateUrl: './search.html',
  styleUrl: './search.css',
})
export class SearchComponent implements OnInit {
  searchText = '';
  result = '';
  searchSubject = new Subject<string>();
  ngOnInit() {
    this.searchSubject.pipe(debounceTime(500), distinctUntilChanged()).subscribe(value => {
      this.result = value;
    });
  }
  onSearch(value: string) {
    this.searchSubject.next(value);
  }
}