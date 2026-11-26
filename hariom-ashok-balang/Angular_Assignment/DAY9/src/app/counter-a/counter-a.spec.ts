import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CounterA } from './counter-a';

describe('CounterA', () => {
  let component: CounterA;
  let fixture: ComponentFixture<CounterA>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CounterA],
    }).compileComponents();

    fixture = TestBed.createComponent(CounterA);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
