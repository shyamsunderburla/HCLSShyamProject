import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddOAdminComponent } from './add-oadmin.component';

describe('AddOAdminComponent', () => {
  let component: AddOAdminComponent;
  let fixture: ComponentFixture<AddOAdminComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AddOAdminComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddOAdminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
