import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditaSensorComponent } from './edita-sensor.component';

describe('EditaSensorComponent', () => {
  let component: EditaSensorComponent;
  let fixture: ComponentFixture<EditaSensorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditaSensorComponent ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditaSensorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
