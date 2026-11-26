import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Prodlist } from './prodlist';

describe('Prodlist', () => {
  let component: Prodlist;
  let fixture: ComponentFixture<Prodlist>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Prodlist],
    }).compileComponents();

    fixture = TestBed.createComponent(Prodlist);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
