import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Movieadd } from './movieadd';

describe('Movieadd', () => {
  let component: Movieadd;
  let fixture: ComponentFixture<Movieadd>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Movieadd],
    }).compileComponents();

    fixture = TestBed.createComponent(Movieadd);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
