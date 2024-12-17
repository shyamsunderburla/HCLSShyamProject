import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OAprofileComponent } from './oaprofile.component';

describe('OAprofileComponent', () => {
  let component: OAprofileComponent;
  let fixture: ComponentFixture<OAprofileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [OAprofileComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OAprofileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
