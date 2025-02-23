import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QrcodeDialogComponent } from './qrcode-dialog.component';

describe('QrcodeDialogComponent', () => {
  let component: QrcodeDialogComponent;
  let fixture: ComponentFixture<QrcodeDialogComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [QrcodeDialogComponent]
    });
    fixture = TestBed.createComponent(QrcodeDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
