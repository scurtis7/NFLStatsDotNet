import { TestBed } from '@angular/core/testing';

import { NflstatsService } from './nflstats.service';

describe('NflstatsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: NflstatsService = TestBed.get(NflstatsService);
    expect(service).toBeTruthy();
  });
});
