import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageOAdminComponent } from './manage-oadmin.component';

describe('ManageOAdminComponent', () => {
  let component: ManageOAdminComponent;
  let fixture: ComponentFixture<ManageOAdminComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ManageOAdminComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManageOAdminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
