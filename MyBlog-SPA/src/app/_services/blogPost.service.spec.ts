/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { BlogPostService } from './blogPost.service';

describe('Service: BlogPost', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [BlogPostService]
    });
  });

  it('should ...', inject([BlogPostService], (service: BlogPostService) => {
    expect(service).toBeTruthy();
  }));
});
