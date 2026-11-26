import { TestBed } from '@angular/core/testing';

import { Deptservice } from './deptservice';

describe('Deptservice', () => {
  let service: Deptservice;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Deptservice);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
