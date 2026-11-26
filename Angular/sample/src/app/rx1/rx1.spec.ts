import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Rx1 } from './rx1';

describe('Rx1', () => {
  let component: Rx1;
  let fixture: ComponentFixture<Rx1>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Rx1],
    }).compileComponents();

    fixture = TestBed.createComponent(Rx1);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
