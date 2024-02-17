import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MonthlyNewCommentsComponent } from './monthly-new-comments.component';

describe('MonthlyNewCommentsComponent', () => {
  let component: MonthlyNewCommentsComponent;
  let fixture: ComponentFixture<MonthlyNewCommentsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MonthlyNewCommentsComponent]
    });
    fixture = TestBed.createComponent(MonthlyNewCommentsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
