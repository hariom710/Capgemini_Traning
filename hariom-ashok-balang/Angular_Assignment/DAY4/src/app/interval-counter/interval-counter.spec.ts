import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IntervalCounter } from './interval-counter';

describe('IntervalCounter', () => {
  let component: IntervalCounter;
  let fixture: ComponentFixture<IntervalCounter>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [IntervalCounter],
    }).compileComponents();

    fixture = TestBed.createComponent(IntervalCounter);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
