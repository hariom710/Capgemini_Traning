import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CounterB } from './counter-b';

describe('CounterB', () => {
  let component: CounterB;
  let fixture: ComponentFixture<CounterB>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CounterB],
    }).compileComponents();

    fixture = TestBed.createComponent(CounterB);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
