import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CompleteOrderDialogComponent } from './complete-order-dialog.component';

describe('CompleteOrderDialogComponent', () => {
  let component: CompleteOrderDialogComponent;
  let fixture: ComponentFixture<CompleteOrderDialogComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CompleteOrderDialogComponent]
    });
    fixture = TestBed.createComponent(CompleteOrderDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
