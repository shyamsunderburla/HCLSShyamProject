import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ActivateAdminComponent } from './activate-admin.component';

describe('ActivateAdminComponent', () => {
  let component: ActivateAdminComponent;
  let fixture: ComponentFixture<ActivateAdminComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ActivateAdminComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ActivateAdminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
