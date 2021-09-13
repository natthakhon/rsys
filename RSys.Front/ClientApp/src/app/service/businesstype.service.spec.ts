import { TestBed } from '@angular/core/testing';

import { BusinesstypeService } from './businesstype.service';

describe('BusinesstypeService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: BusinesstypeService = TestBed.get(BusinesstypeService);
    expect(service).toBeTruthy();
  });
});
