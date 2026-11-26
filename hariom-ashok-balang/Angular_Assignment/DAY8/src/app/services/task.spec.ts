import { TestBed } from '@angular/core/testing';
import {Injectable} from '@angular/core';
import {Task} from '../models/task.model';
import {LoggingService} from './logging.service';

describe('Task', () => {
  let service: Task;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Task);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
