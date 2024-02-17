import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KnowledgeBasesComponent } from './knowledge-bases.component';

describe('KnowledgeBasesComponent', () => {
  let component: KnowledgeBasesComponent;
  let fixture: ComponentFixture<KnowledgeBasesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [KnowledgeBasesComponent]
    });
    fixture = TestBed.createComponent(KnowledgeBasesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
