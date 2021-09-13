import { TestBed } from '@angular/core/testing';

import { QnaireService } from './qnaire.service';

describe('QnaireService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: QnaireService = TestBed.get(QnaireService);
    expect(service).toBeTruthy();
  });
});
