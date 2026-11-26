import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NumberFilter } from './number-filter';

describe('NumberFilter', () => {
  let component: NumberFilter;
  let fixture: ComponentFixture<NumberFilter>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [NumberFilter],
    }).compileComponents();

    fixture = TestBed.createComponent(NumberFilter);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
