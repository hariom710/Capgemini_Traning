import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Reactform } from './reactform';

describe('Reactform', () => {
  let component: Reactform;
  let fixture: ComponentFixture<Reactform>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Reactform],
    }).compileComponents();

    fixture = TestBed.createComponent(Reactform);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
