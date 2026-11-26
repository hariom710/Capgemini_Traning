import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Appcart } from './appcart';

describe('Appcart', () => {
  let component: Appcart;
  let fixture: ComponentFixture<Appcart>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Appcart],
    }).compileComponents();

    fixture = TestBed.createComponent(Appcart);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
