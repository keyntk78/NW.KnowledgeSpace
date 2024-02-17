import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MonthlyNewKbsComponent } from './monthly-new-kbs.component';

describe('MonthlyNewKbsComponent', () => {
  let component: MonthlyNewKbsComponent;
  let fixture: ComponentFixture<MonthlyNewKbsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MonthlyNewKbsComponent]
    });
    fixture = TestBed.createComponent(MonthlyNewKbsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
