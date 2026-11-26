import { Component } from '@angular/core';
import { Subject } from 'rxjs';
import { debounceTime, distinctUntilChanged } from 'rxjs/operators';

@Component({
  selector: 'app-search',
  standalone: false,
  templateUrl: './search.html',
  styleUrl: './search.css',
})
export class Search {
  searchSubject = new Subject<string>();
  searchText='';

  constructor() {
    this.searchSubject
      .pipe(
        debounceTime(300),
        distinctUntilChanged()
      )
      .subscribe((value) => {
        // Handle search logic here
        this.searchText = value;
      });
  }

  onSearch(value: string) {
    this.searchSubject.next(value);
  }
}
