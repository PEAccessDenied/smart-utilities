/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { NewSmartMeterComponent } from './new-smart-meter.component';

describe('NewSmartMeterComponent', () => {
  let component: NewSmartMeterComponent;
  let fixture: ComponentFixture<NewSmartMeterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NewSmartMeterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewSmartMeterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
