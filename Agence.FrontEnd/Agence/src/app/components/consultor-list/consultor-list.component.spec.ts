import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultorListComponent } from './consultor-list.component';

describe('ConsultorListComponent', () => {
  let component: ConsultorListComponent;
  let fixture: ComponentFixture<ConsultorListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ConsultorListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ConsultorListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
