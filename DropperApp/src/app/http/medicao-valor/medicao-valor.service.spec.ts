import { TestBed } from '@angular/core/testing';

import { MedicaoValorService } from './medicao-valor.service';

describe('MedicaoValorService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MedicaoValorService = TestBed.get(MedicaoValorService);
    expect(service).toBeTruthy();
  });
});
