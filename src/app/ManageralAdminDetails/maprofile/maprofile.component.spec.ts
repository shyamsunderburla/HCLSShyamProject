import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MAProfileComponent } from './maprofile.component';

describe('MAProfileComponent', () => {
  let component: MAProfileComponent;
  let fixture: ComponentFixture<MAProfileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MAProfileComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MAProfileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
